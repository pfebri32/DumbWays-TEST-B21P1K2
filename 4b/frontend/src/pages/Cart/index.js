import React from 'react';
import { Container, Col, Row } from 'react-bootstrap';
import { connect } from 'react-redux';
import './index.scss';

function index(props) {
    console.log(props);
    const renderOrders = () => (
        props.orders.map((order, i) => {
            return (
                <Row>
                    <Col>{ props.products[order.id - 1].id }</Col>
                    <Col>{ props.products[order.id - 1].name }</Col>
                    <Col>{ props.products[order.id - 1].merk }</Col>
                    <Col>{ props.products[order.id - 1].price }</Col>
                    <Col>{ order.stock }</Col>
                </Row>
            );
        })
    );
    return (
        <div className='Cart'>
            <div className='segment'>
                <Container>
                    <Row>
                        <Col>ID</Col>
                        <Col>Nama</Col>
                        <Col>Merk</Col>
                        <Col>Harga</Col>
                        <Col>Jumlah</Col>
                    </Row>
                    { renderOrders() }
                </Container>
            </div>
        </div>
    )
}

const mapStateToProps = (state) => ({
    orders: state.orders, 
    products: state.products,
});

export default connect(mapStateToProps)(index);