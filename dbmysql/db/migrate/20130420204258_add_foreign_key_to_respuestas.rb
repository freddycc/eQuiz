class AddForeignKeyToRespuestas < ActiveRecord::Migration
  def change
  	add_index :respuestas, :prueba_id
  end
end
