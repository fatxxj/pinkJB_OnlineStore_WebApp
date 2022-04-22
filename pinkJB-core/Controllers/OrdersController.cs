﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using pinkJB_core.Data.Cart;
using pinkJB_core.Data.ViewModels;
using pinkJB_core.Models;
using pinkJB_core.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace pinkJB_core.Controllers
{
    public class OrdersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProductsService _productsService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _ordersService;

        public OrdersController(IProductsService productsService, ShoppingCart shoppingCart, IOrdersService ordersService,  UserManager<ApplicationUser> userManager)
        {
            _productsService = productsService;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var orders = await _ordersService.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(orders);

        }
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();//return list of shopping cart item
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
        public async Task<IActionResult> AddToShoppingCart(int id)
        {
            var item = await _productsService.GetByIdAsync(id);
            if(item!=null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction("Store","Home");
        }


        public async Task<IActionResult> RemoveFromShoppingCart(int id)
        {
            var item = await _productsService.GetByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        /*
        public string GetHTMLString()
        {

            var items = _shoppingCart.GetShoppingCartItems();

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Id</th>
                                        <th>Product Name</th>
                                        <th>Amount</th>
                                        <th>ShoppingCartId</th>
                                    </tr>");

            foreach (var item in items)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", item.Product.Id, item.Product.ProductName, item.Amount, item.ShoppingCartId);
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();

        }
        */

        public async Task<IActionResult> CompleteOrder()
        {
            
            var items=_shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email); 
            await _ordersService.StoreOrderAsync(items,userId,userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();
            double total1 = 0;
            var message = "";
            foreach (var item in items)
            {
                var total = item.Amount * item.Product.ProductPrice;
                message += "You have successfuly ordered  " + item.Product.ProductName + " whith a  price of " + total + "<br>";
                 total1 = total1 + total;
               
            }
            message += " The grand total is: " + total1;

            MailMessage mm = new MailMessage();
            mm.Subject = "Successful order";
            mm.Body = message;
            mm.IsBodyHtml = true;
            mm.From = new MailAddress("pink.jb10@gmail.com", "Pink JB admin");
            mm.To.Add(new MailAddress(userEmailAddress, "Fat Halimi"));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential("pink.jb10@gmail.com", "Pinkjb@1234");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);


            MailMessage mailAdmin = new MailMessage();
            mailAdmin.Subject = "Successful order made by: "+userEmailAddress;
            mailAdmin.Body = message;
            mailAdmin.IsBodyHtml = true;
            mailAdmin.From = new MailAddress("pink.jb10@gmail.com", "Pink JB admin");
            mailAdmin.To.Add(new MailAddress("pink.jb10@gmail.com", "PinkJB"));
             smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
             NetworkCred = new NetworkCredential("pink.jb10@gmail.com", "Pinkjb@1234");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mailAdmin);


            return View("OrderCompleted");
        }


    }
}
