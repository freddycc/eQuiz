class CreateRespuesta < ActiveRecord::Migration
  def change
    create_table :respuestas do |t|
      t.string :respuesta
      t.integer :estudiante_id
      t.integer :prueba_id

      t.timestamps
    end
  end
end
