import { useState } from 'react';
import reactLogo from './assets/react.svg';
import viteLogo from '/vite.svg';
import './App.css';
import BowlerList from './BowlerList';
import Header from './Header';

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <div>
        <Header />
        <BowlerList />
      </div>
    </>
  );
}

export default App;
