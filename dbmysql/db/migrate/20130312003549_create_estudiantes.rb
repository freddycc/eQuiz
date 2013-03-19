class CreateEstudiantes < ActiveRecord::Migration
  def change
    create_table :estudiantes do |t|
      t.integer :id
      t.string :cedula
      t.string :nombre
      t.string :apellidos
      t.string :email
      t.string :username
      t.string :password

      t.timestamps
    end
  end
end
