class CreateProfesores < ActiveRecord::Migration
  def change
    create_table :profesores do |t|
      t.string :username
      t.string :email
      t.string :cedula
      t.string :nombre
      t.string :apellido
      t.string :password

      t.timestamps
    end
  end
end
