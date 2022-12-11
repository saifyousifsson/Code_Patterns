import React from 'react'
import { useState,useEffect } from 'react';
import axios from 'axios'
import ListOfProduct from './ListOfProduct';
const ForUsd = () => {
    const [product, setProuct] = useState([]);
    useEffect(() => {
      axios.get('https://localhost:7292/api/Prroduct',{
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
   <section className=' row'>
    
        <div className='col  '>    
          <div className='for-2 '>
            <div className='for-usd text-center' >2 FOR USD $29</div>
            <button className='btn-flase'>FLASE SALE</button>
       </div>
        </div>
        
   </section><div className=' coly   '>
   <div className='row row-cols-3  '>
         
        { product.length > 0  ?   product.slice(0-4).map((item )=> 
      <div className="pro-usd  col">
       <ListOfProduct  key={item.id} item={item}/>
      </div>   
    )
       : <p>No Pouduct to show</p>
    } </div>  </div>
 </div></div>
  )
}

export default ForUsd