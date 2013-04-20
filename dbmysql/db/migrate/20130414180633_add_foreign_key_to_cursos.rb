class AddForeignKeyToCursos < ActiveRecord::Migration
  def change
  	add_index :cursos, :profesore_id
  end
end
