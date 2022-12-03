
import Navbar from './components/Navbar';
import{ Routes,Route} from 'react-router-dom';
import Home from './components/Home';

function App() {
  return (
    <>
    <Navbar/>
    <div className="container">
      <Routes>
      <Route  path='/' element={<Home/>}/>
      </Routes>
    
    </div>
    </>
  );
}

export default App;
