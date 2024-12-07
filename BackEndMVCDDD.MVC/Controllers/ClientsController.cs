using AutoMapper;
using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Infra.Data.Repositories;
using BackEndMVCDDD.MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndMVCDDD.MVC.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();
        private readonly IMapper _mapper;

        public ClientsController(ClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper; // Injeção de dependência do Mapper
        }
        // GET: ClientsController
        public ActionResult Index()
        {
            var clients = _clientRepository.GetAll();
            var clientViewModels = _mapper.Map<IEnumerable<ClientViewModel>>(clients);
            return View(clientViewModels);
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel client)
        {
            if(ModelState.IsValid)
            {
                var clientDomain = _mapper.Map<ClientViewModel, Client>(client);
                _clientRepository.Add(clientDomain);

                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
