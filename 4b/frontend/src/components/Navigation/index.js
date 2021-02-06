import React from 'react';
import { Container } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import './index.scss';

export default function index() {
    return (
        <div className='Navigation'>
            <Container className='nav__container'>
                <Link className='logo' to='/'>DW Bike</Link>
                <div className='links'>
                    <Link className='link' to='/cart'>My Order</Link>
                </div>
            </Container>
        </div>
    )
}
