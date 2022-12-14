import React from 'react'
import { useState,useEffect } from 'react';
import axios from 'axios'
import ListOfProduct from './ListOfProduct';
const UsdFor = () => {
    const [product, setProuct] = useState([]);
    useEffect(() => {
      axios.get('https://localhost:7292/api/Product',{
        headers: {
          'content-type': 'application/json',
      
        }
      })
   
        .then(res=>{
          
            // console.log(res.Error);
            console.log(res.data);
            setProuct(res.data);
        })
        .catch(err => {
          console.log(err);
        });
  

    }, []);
  return (
    <div className='container '>
    <div className=' d-flex '>
    <div className=' coly   '>
   <div className='row row-cols-3  '>
         
        { product.length > 0  ?   product.slice(0-4).map((item )=> 
      <div className="pro-usd-1  col">
       <ListOfProduct  key={item.id} item={item}/>
      </div>   
    )
       : <p>No Pouduct to show</p>
    } </div> 
     </div>
   <section className=' row '>
    
        <div className='col  '>    
          <div className='for-3 '>
            <div className='for-usd-1 text-center' >2 FOR USD $29</div>
            <button className='btn-flase'>FLASE SALE</button>
       </div>
        </div>
        
   </section>
 </div></div>
  )
}

export default UsdFor