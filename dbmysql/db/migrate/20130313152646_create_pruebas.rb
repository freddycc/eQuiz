class CreatePruebas < ActiveRecord::Migration
  def change
    create_table :pruebas do |t|
      t.string :nombre
      t.integer :curso
      t.date :fecha
      t.text :preguntas
      t.string :estado
      t.string :duracion
      t.string :calificacion
      t.text :comentario

      t.timestamps
    end
  end
end
