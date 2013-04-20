class CursosController < ApplicationController
  # GET /cursos
  # GET /cursos.json
  def index
    @cursos = Curso.find_by_sql("SELECT c.id,c.codigo,c.nombre,c.descripcion,p.cedula FROM cursos as c, profesores as p WHERE c.profesore_id=p.id")#all

    respond_to do |format|
      if @cursos.empty?
        format.html # index.html.erb
        format.json { render json: @cursos }
        format.xml { head :no_content }
      else
        format.html # index.html.erb
        format.json { render json: @cursos }
        format.xml { render xml: @cursos }
      end
    end
  end

  # GET /cursos/1
  # GET /cursos/1.json
  def show
    @curso = Curso.find(params[:id])

    respond_to do |format|
      format.html # show.html.erb
      format.json { render json: @curso }
    end
  end

  # GET /cursos/1/estudiantes.xml
  def estudiantes
    @curso = Curso.find(params[:id])
    @estudiantes = @curso.estudiantes
    respond_to do |format|
      if @estudiantes.empty?
        format.xml { head :no_content }
      else
         format.xml { render xml: @estudiantes }
      end
    end
  end

  # GET /cursos/1/noestudiantes.xml
  def noestudiantes
    @curso = Curso.find(params[:id])
    @matriculados = @curso.estudiantes
    @estudiantes = Estudiante.all
    if @matriculados.empty?
      respond_to do |format|
        if @estudiantes.empty?
          format.xml { head :no_content }
        else
          format.xml { render xml: @estudiantes }
        end
      end
    else
      @matriculados.each do |matriculado|
        @estudiantes.each do |estudiante|
          if matriculado.id==estudiante.id
            estudiante.id = nil
            estudiante.nombre = nil
            estudiante.cedula = nil
            estudiante.apellidos = nil
            estudiante.email = nil
            estudiante.username = nil
            estudiante.password = nil
            estudiante.created_at = nil
            estudiante.updated_at = nil
          end
        end
      end
      respond_to do |format|
        if @estudiantes.empty?
          format.xml { head :no_content }
        else
          format.xml { render xml: @estudiantes }
        end      
      end
    end    
  end

  # GET /cursos/1/pruebas.xml
  def pruebas
    @curso = Curso.find(params[:id])
    @pruebas = @curso.pruebas

    respond_to do |format|
      if @pruebas.empty?
        format.xml { head :no_content }
      else
        format.xml { render xml: @pruebas}
      end
    end
  end

  # GET /cursos/new
  # GET /cursos/new.json
  def new
    @curso = Curso.new

    respond_to do |format|
      format.html # new.html.erb
      format.json { render json: @curso }
    end
  end

  # GET /cursos/1/edit
  def edit
    @curso = Curso.find(params[:id])
  end

  # POST /cursos
  # POST /cursos.json
  def create
    @curso = Curso.new
    @curso.codigo = params[:codigo]
    @curso.nombre = params[:nombre]
    @curso.descripcion = params[:descripcion]

    @profesore = Profesore.find_by_cedula(params[:cedula])
    @curso.profesore_id = @profesore.id
    respond_to do |format|
      if @curso.save
        format.html { redirect_to @curso, notice: 'Curso was successfully created.' }
        format.json { render json: @curso, status: :created, location: @curso }
      else
        format.html { render action: "new" }
        format.json { render json: @curso.errors, status: :unprocessable_entity }
      end
    end
  end

  # PUT /cursos/1
  # PUT /cursos/1.json
  def update
    @curso = Curso.find(params[:id])

    respond_to do |format|
      if @curso.update_attributes(params[:curso])
        format.html { redirect_to @curso, notice: 'Curso was successfully updated.' }
        format.json { head :no_content }
      else
        format.html { render action: "edit" }
        format.json { render json: @curso.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /cursos/1
  # DELETE /cursos/1.json
  def destroy
    @curso = Curso.find(params[:id])
    @curso.destroy

    respond_to do |format|
      format.html { redirect_to cursos_url }
      format.json { head :no_content }
    end
  end

  # DELETE /cursos/1/1/delmatricula.json
  def delmatricula
    @curso = Curso.find(params[:curso_id])
    @matriculados = @curso.estudiantes
    @estudiante = Estudiante.find(params[:estudiante_id])
    @matriculados.delete(@estudiante)

    respond_to do |format|
      format.json { head :no_content }
    end
  end
end
