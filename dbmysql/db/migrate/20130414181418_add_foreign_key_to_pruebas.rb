class AddForeignKeyToPruebas < ActiveRecord::Migration
  def change
  	add_index :pruebas, :curso_id
  end
end
