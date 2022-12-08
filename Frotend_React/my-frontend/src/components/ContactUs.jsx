import React from 'react'

const ContactUs = () => {
  return (
    <>
    <div className="mb-3 mt-5 row">
  
  <input type="name" className="col m-2 px-2 mx-3 form-control"  placeholder="Your Name"/>
  <input type="email" className="col m-2 px-2 mx-3 form-control"  placeholder="Your Mail"/>
  </div>
 <div className="mb-3">
  <textarea className="form-control p-3 px-3  mx-0" placeholder="Comments" rows="3"></textarea>
</div>
<button className='btn m-1 my-0 py-4 mb-5'> Post Comments</button>
 </>
  )
}

export default ContactUs