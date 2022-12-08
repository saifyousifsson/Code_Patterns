
import Navbar from './components/Navbar';
import{ Routes,Route} from 'react-router-dom';
import Home from './pages/Home';
import Contacts from './pages/Contacts';

function App() {
  return (
    <>
    <Navbar/>
    <div className="container">
      <Routes>
      <Route  path='/' element={<Home/>}/>
      <Route  path='/contacts' element={<Contacts/>}/>
      </Routes>
    
    </div>
    </>
  );
}

export default App;
