import React, { useEffect, useState } from "react";
import axios from "axios";

const ProductData = () => {
  const [id, setId] = useState("");
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");
  const [category, setCategory] = useState("");
  const [products, setProducts] = useState([]);

  const baseUrl = "https://localhost:7060/api/Product";

  // Load
  useEffect(() => {
    Load();
  }, []);

  const Load = async () => {
    try {
      const res = await axios.get(baseUrl);
      setProducts(res.data);
    } catch (err) {
      console.error(err);
    }
  };

  // Save (POST)
  const save = async (e) => {
    e.preventDefault();
    try {
      await axios.post(baseUrl, {
        name,
        price: parseFloat(price),
        category,
      });

      alert("Product Added Successfully");
      resetForm();
      Load();
    } catch (err) {
      console.error(err);
      alert("Error adding product");
    }
  };

  // Edit
  const editProduct = (p) => {
    setId(p.id);
    setName(p.name);
    setPrice(p.price);
    setCategory(p.category);
  };

  // Delete
  const deleteProduct = async (id) => {
    try {
      await axios.delete(`${baseUrl}/${id}`);
      alert("Deleted Successfully");
      Load();
    } catch (err) {
      console.error(err);
    }
  };

  // Update (PUT ✅ FIXED)
  const update = async (e) => {
    e.preventDefault();
    try {
      await axios.put(`${baseUrl}/${id}`, {
        name,
        price: parseFloat(price),
        category,
      });

      alert("Updated Successfully");
      resetForm();
      Load();
    } catch (err) {
      console.error(err);
      alert("Error updating");
    }
  };

  const resetForm = () => {
    setId("");
    setName("");
    setPrice("");
    setCategory("");
  };

  return (
    <div className="container mt-4">
      <h2>Product CRUD</h2>

      <form>
        <input type="hidden" value={id} />

        <div className="mb-2">
          <label>Name</label>
          <input
            className="form-control"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
        </div>

        <div className="mb-2">
          <label>Price</label>
          <input
            type="number"
            className="form-control"
            value={price}
            onChange={(e) => setPrice(e.target.value)}
          />
        </div>

        <div className="mb-2">
          <label>Category</label>
          <input
            className="form-control"
            value={category}
            onChange={(e) => setCategory(e.target.value)}
          />
        </div>

        <button className="btn btn-primary me-2" onClick={save}>
          Add
        </button>

        <button className="btn btn-warning" onClick={update}>
          Update
        </button>
      </form>

      <hr />

      <table className="table table-dark text-center">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Price</th>
            <th>Category</th>
            <th>Action</th>
          </tr>
        </thead>

        <tbody>
          {products.map((p) => (
            <tr key={p.id}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.price}</td>
              <td>{p.category}</td>
              <td>
                <button
                  className="btn btn-warning me-2"
                  onClick={() => editProduct(p)}
                >
                  Edit
                </button>

                <button
                  className="btn btn-danger"
                  onClick={() => deleteProduct(p.id)}
                >
                  Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default ProductData;