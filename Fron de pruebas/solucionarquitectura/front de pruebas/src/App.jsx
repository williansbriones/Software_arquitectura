import { useState } from 'react'
import './App.css'
import axios  from 'axios';





function App() {
  
  const [nombre, setnomrbe] = useState("");
  const [rut, setrut ] = useState("");
  const [usuarios, setusuarios] =useState();

  function obtenerUsuarios(){

    let config = {
      method: 'get',
      maxBodyLength: Infinity,
      url: 'http://localhost:443/usuarios',
      headers: { }
    };
    
    axios.request(config)
    .then((response) => {
      console.log(JSON.stringify(response.data));
    })
    .catch((error) => {
      console.log(error);
    });

  }
  function Getusuario(rut){
    
    let config = {
      method: 'get',
      maxBodyLength: Infinity,
      url: 'http://localhost:443/usuario',
      headers: { 
        'Rut': rut
      }
    };
    
    axios.request(config)
    .then((response) => {
      console.log(JSON.stringify(response.data));
      setnomrbe(response.data.nombre);
      setrut(response.data.rut);

    })
    .catch((error) => {
      console.log(error);
    });

  }
  function borrarinfo(){
    setnomrbe("");
    setrut("");
  }
  function login(usuario, cont){
    

    let config = {
      method: 'get',
      maxBodyLength: Infinity,
      url: 'http://localhost:443/login',
      headers: { 
        'Usuriao': usuario, 
        'contrasena': cont
      }
    };
    
    axios.request(config)
    .then((response) => {
      console.log(JSON.stringify(response.data));
    })
    .catch((error) => {
      console.log(error);
    });
  }

  return (
    <>
      <button onClick={() => Getusuario("20.811.954-0")} id='boton'>inicio de sesion</button>
      <h1>nombre: <span>{nombre}</span></h1>
      <h2>RUT: <span>{rut}</span></h2>

      <button onClick={obtenerUsuarios}>Usuarios</button>
      <br />
      <br />
      <button onClick={borrarinfo}>borrarinfo</button>
      <br />
      <br />
      <button onClick={() => login( "asdf" , "20.811.954-0")}>login</button>
      <p>{usuarios}</p>
    </>
  )
}






export default App
