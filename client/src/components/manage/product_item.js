import React from 'react';
import { NavLink } from 'react-router-dom';
import './product_item.css';

const ProductItem = ({product}) => {
  const EDIT_ROUTE = `/Manage/Edit/${product.ProductId}`;
  return (
    <tr className="data-name">
        <th className="align-middle" scope="row">{product.ProductId}</th>
        <td className="align-middle">{product.Condition}</td>
        <td className="align-middle">{product.Product}</td>
        <td className="align-middle"><img className="product-image" src={product.Image} alt="" /></td>
        <td className="align-middle">{product.CategoryName}</td>
        <td className="align-middle">{product.SubCategoryName}</td>
        <td className="align-middle">{product.Cents}</td>
        <td className="align-middle">{product.Availability}</td>
        <td className="align-middle edit"><NavLink to={EDIT_ROUTE}><i className="ion-md-create">Edit</i></NavLink></td>
        <td className="align-middle remove"><NavLink to="/"><i className="ion-md-trash">Trash</i></NavLink></td>
    </tr>
  );
}

export default ProductItem;
