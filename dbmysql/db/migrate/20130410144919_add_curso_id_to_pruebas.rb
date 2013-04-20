class AddCursoIdToPruebas < ActiveRecord::Migration
  def change
    add_column :pruebas, :curso_id, :integer
  end
end
