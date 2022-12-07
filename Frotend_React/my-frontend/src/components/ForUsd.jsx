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
   <div className='container'>
    <div className='row'>
        <div className='col'>    
          <div className='for-2'>
            <div className='for-usd text-center' >2 FOR USD $29</div>
            <button className='btn-flase'>FLASE SALE</button>
          </div>
        </div>
        
        { product.length > 0 ?   product.map((item)=> 
      <div className=" col-lg-2  ">
       <ListOfProduct  key={item.id} item={item}/>
      </div>   
    )
       : <p>No Pouduct to show</p>
    }
    </div>
   </div>
  )
}

export default ForUsd