import { useEffect, useState } from 'react';

// Define the Bowler interface for type safety
interface Bowler {
  bowlerID: number;
  bowlerName: string;
  teamName: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
}

function BowlerList() {
  // State to store the list of bowlers
  const [bowlers, setBowlers] = useState<Bowler[]>([]);

  useEffect(() => {
    // Fetch bowler data from the API on component mount
    const fetchBowlers = async () => {
      try {
        const response = await fetch('http://localhost:5000/api/bowler');
        const data = await response.json();

        console.log('Fetched Bowlers:', data);
        setBowlers(data);
      } catch (error) {
        console.error('Error fetching bowlers:', error);
      }
    };

    fetchBowlers();
  }, []); // Empty dependency array ensures this runs only once

  return (
    <div>
      <h2>Bowlers List</h2>
      <table>
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {/* Render each bowler in a table row */}
          {bowlers.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerName || 'Unknown'}</td>
              <td>{b.teamName || 'No Team'}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default BowlerList;
