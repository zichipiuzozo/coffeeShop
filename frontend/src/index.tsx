import React from "react";
import ReactDOM from "react-dom/client";
import "./global.scss";
import App from "./App";
import ThemeContextProvider from "./context/theme.context";
const BrowserRouter = require("react-router-dom").BrowserRouter;

const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);
root.render(
  <ThemeContextProvider>
    <BrowserRouter>
      <App />
    </BrowserRouter>
  </ThemeContextProvider>
);
