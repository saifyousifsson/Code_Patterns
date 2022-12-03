import React from 'react'
import { Link, NavLink } from 'react-router-dom'
const Navbar = () => {
  return (
    <nav className="navbar navbar-expand-lg bg-light">
  <div className="container  ">
    <Link className="navbar-brand" to="/">Navbar</Link>
    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span className="navbar-toggler-icon"></span>
    </button>
    <form className='d-flex'>
    <div className="collapse navbar-collapse " id="navbarNav">
      <ul className="navbar-nav ">
        
        <li><NavLink className='nav-link'  to="/" >Home</NavLink></li>
         <li><NavLink className='nav-link'  to="/home" end>Home</NavLink></li>
         <li><NavLink className='nav-link'  to="/" >Home</NavLink></li>
         <li><NavLink className='nav-link'  to="/" >Home</NavLink></li>
 
      </ul>
    </div></form>
  </div>
</nav>
  )
}

export default Navbar