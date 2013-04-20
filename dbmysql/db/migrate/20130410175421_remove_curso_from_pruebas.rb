class RemoveCursoFromPruebas < ActiveRecord::Migration
  def up
    remove_column :pruebas, :curso
  end

  def down
    add_column :pruebas, :curso, :integer
  end
end
