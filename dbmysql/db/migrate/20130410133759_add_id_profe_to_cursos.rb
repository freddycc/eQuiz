class AddIdProfeToCursos < ActiveRecord::Migration
  def change
    add_column :cursos, :profesore_id, :integer
  end
end
