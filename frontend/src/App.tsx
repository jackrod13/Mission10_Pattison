import { useState } from 'react';
import reactLogo from './assets/react.svg';
import viteLogo from '/vite.svg';
import './App.css';
import BowlerList from './BowlerList';
import Header from './Header';

function App() {
  // State for tracking a count (not currently used in the UI)
  const [count, setCount] = useState(0);

  return (
    <>
      <div>
        {/* Render the header and bowler list components */}
        <Header />
        <BowlerList />
      </div>
    </>
  );
}

export default App;
