package com.jicmon.integration;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.jicmon.entities.Viaggio;
import com.jicmon.services.ViaggiService;

@RestController
@RequestMapping("api")
public class ViaggiREST {
	@Autowired
	private ViaggiService service;
	
	@GetMapping
	public List<Viaggio> getViaggi(){
		return service.getViaggi();
	}
	
	@PostMapping
	public Viaggio addViaggio(@RequestBody Viaggio v) {
		return service.addViaggio(v);
		
	}
	

}
