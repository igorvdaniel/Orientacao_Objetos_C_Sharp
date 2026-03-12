import './Login.css'
import React, { useState } from 'react';

function Login() {
    const [email, setEmail] = useState<string>("");
    const Mudanca_Email = (event: React.ChangeEvent<HTMLInputElement>) => {
    setEmail(event.target.value);
  };

  return (
    <>
        <div className='login-container'>
            <div className='login-card'>
                <div className='card-cabecalho'>
                    <h1>Logue com o seu email!</h1>
                </div>
                <div className='card-input'>
                     <div>
                          <input 
                            type="email" 
                            value={email} 
                            onChange={Mudanca_Email} 
                            placeholder="seuemail@gmail.com" 
                          />
                        <div className='card-button'>
                                <button type="submit" className="button">Entrar</button>                        
                        </div>
                    </div>               
                </div>
            </div>
        </div>
    </>
  )
}

export default Login