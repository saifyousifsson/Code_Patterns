import React from 'react'
import FlaseSale from '../components/FlaseSale'
import ForUsd from '../components/ForUsd'
import Product from '../components/Product'
import SaleUp from '../components/SaleUp'

const Home = () => {
  return (
    <>
     <SaleUp/>
     <Product/>
     <FlaseSale/>
     <ForUsd/>
    </>
   
  )
}

export default Home