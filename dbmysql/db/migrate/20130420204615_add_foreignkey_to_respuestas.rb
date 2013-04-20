class AddForeignkeyToRespuestas < ActiveRecord::Migration
  def change
  	add_index :respuestas, :estudiante_id
  end
end
