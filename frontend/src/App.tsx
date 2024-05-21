import {useContext} from "react";
import { ThemeContext } from "./context/theme.context";

const App = () => {
  const themeContext = useContext(ThemeContext);

  console.log(themeContext);
  return (
    <div className='app'>App</div>
  )
}

export default App