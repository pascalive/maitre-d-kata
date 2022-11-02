using kata.model.contact;
using maitre_d.model;
using maitre_d.model.contact;
using maitre_d.service;
using Microsoft.AspNetCore.Mvc;

namespace maitre_d.controller;

[Route("api/[controller]")]
[ApiController]
public class RestaurantController: Controller
{
    private readonly IMaitreDService _maitreDService;
    
    public RestaurantController(IMaitreDService maitreDService)
    {
        _maitreDService = maitreDService;
    }

    [HttpGet]
    public bool Get()
    {
        return this._maitreDService.ProcessReservation(
            new Restaurant(new PersonCount(30)),
            new Reservation(new DateTime(0), new PersonCount(20), new Contact(new Name(""))));
    }
}