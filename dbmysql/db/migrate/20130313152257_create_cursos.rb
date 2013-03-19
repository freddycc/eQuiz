class CreateCursos < ActiveRecord::Migration
  def change
    create_table :cursos do |t|
      t.integer :codigo
      t.string :nombre
      t.string :descripcion

      t.timestamps
    end
  end
end
