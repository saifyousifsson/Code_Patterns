import React from 'react'
import FlaseSale from '../components/FlaseSale'
import Footer from '../components/Footer'
import ForUsd from '../components/ForUsd'
import Product from '../components/Product'
import SaleUp from '../components/SaleUp'
import Support from '../components/Support'

const Home = () => {
  return (
    <>
     <SaleUp/>
     <Product/>
     <FlaseSale/>
     <ForUsd/>
     <Support/>
    <Footer/>
    </>
   
  )
}

export default Home