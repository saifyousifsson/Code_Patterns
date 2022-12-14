import React from 'react'

const ListOfProduct = ({item}) => {
  return (
    <div className=" card  ">
    <div className="bg-image  hover-zoom  ">
      <img src={item.imag} className="w-100 " alt=''/>
     
    </div>
    <div className="card-body mb-0">
         <p className='mb-1   '>{item.categoryName}</p>
    
        <p className="card-title  fs-4  mt-2 mb-2">{item.name}</p>
     
      <h6 className="mb-1">{item.price} kr</h6>
    </div>
  </div>
  )
}

export default ListOfProduct