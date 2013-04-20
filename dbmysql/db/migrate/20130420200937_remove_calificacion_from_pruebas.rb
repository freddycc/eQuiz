class RemoveCalificacionFromPruebas < ActiveRecord::Migration
  def up
    remove_column :pruebas, :calificacion
  end

  def down
    add_column :pruebas, :calificacion, :integer
  end
end
