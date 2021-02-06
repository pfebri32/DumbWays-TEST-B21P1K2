import React from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import { connect } from 'react-redux';
import './index.scss';

function index(props) {
    const onAddOrder = (id) => {
        for (var i = 0; i < props.orders.length; i++) {
            if (props.orders[i].id == id) return; 
        }
        props.addOrder(id);
        console.log(props.orders);
    };
    const renderProducts = () => (
        props.products.map(product => (
            product.stock > 0 ? (
                <Col lg={3}>
                    <div className='content'>
                        <div className='image'><img src={`${process.env.PUBLIC_URL + '/london_taxi_sepeda_lipat_amadeus_fdb20_steel_full06_cs4cdf0k.jpg'}`} alt=''/></div>
                        <div className='infos'>
                            <div className='name'>{ product.name }</div>
                            <div className='merk'>{ product.merk }</div>
                            <div className='stock'>{ `Stock: ${product.stock}` }</div>
                            <div className='price'>{ product.price }</div>
                        </div>
                        <div className='buy' onClick={() => onAddOrder(product.id)}>Buy</div>
                    </div>
                </Col>
            ) : null
        ))
    );
    return (
        <div className='Main'>
            <div className='segment'>
                <Container>
                    <Row>
                        { renderProducts() }
                    </Row>
                </Container>
            </div>
        </div>
    )
}

const mapStateToProps = (state) => ({
    products: state.products,
    orders: state.orders,
});

const mapDispatchToProps = dispatch => {
    return {
        addOrder: (id) => dispatch({type: 'ADD_ORDER', id: id, stock: 1})
    };
};


export default connect(mapStateToProps, mapDispatchToProps)(index);