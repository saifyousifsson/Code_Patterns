import React from 'react'

const ListOfProduct = ({item}) => {
  return (
    <div className=" card  ">
    <div className="bg-image  hover-zoom  ">
      <img src={item.imag} className="w-100 " alt=''/>
     
    </div>
    <div className="card-body mb-0">
         <p className='mb-1 fs-5'>{item.category.name}</p>
    
        <h5 className="card-title mb-2">{item.name}</h5>
     
      <h6 className="mb-1">{item.price}</h6>
    </div>
  </div>
  )
}

export default ListOfProduct