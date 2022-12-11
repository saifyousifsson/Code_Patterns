import React from 'react'
import { useState,useEffect } from 'react';
import axios from 'axios'
import ListOfProduct from './ListOfProduct';


const Product = () => {
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
 
   <section >
     <div className="text-center container px-5 py-5">
    <h4 className="mt-4 mb-5"><strong>Featured Product</strong></h4>
   
    <div className="row ">
    { product.length > 0 ?   product.slice(0-8).map((item)=> 
      <div className="col-lg-3 col-md-12 mb-4  ">
       <ListOfProduct key={item.id} item={item}/>
      </div>   
    )
       : <p>No Pouduct to show</p>
    }
    </div>

    </div>
   </section>

   )

  
}

export default Product