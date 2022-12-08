import React from 'react'
import ContactUs from '../components/ContactUs'
import Footer from '../components/Footer'
import Map from '../components/Map'

const Contacts = () => {
  return (
    <div>
     <h5 className='m-4'>Contacts</h5>
         <Map/>
         <ContactUs/>
         <Footer/>
    </div>
  )
}

export default Contacts