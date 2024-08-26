/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,js}"],
  theme: {
    extend: {
      colors: {
        'blue-facebook': '#0866ff',
        'verde-facebook': '#42b72a',
        'cinza-facebook': '#f2f4f7',
      },
      spacing:{
        '580': '580px',
        '380': '380px',
      }
    },
  },
  plugins: [],
}

