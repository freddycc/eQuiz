class RespuestaController < ApplicationController
  # GET /respuesta
  # GET /respuesta.json
  def index
    @respuesta = Respuestum.all

    respond_to do |format|
      format.html # index.html.erb
      format.json { render json: @respuesta }
    end
  end

  # GET /respuesta/1
  # GET /respuesta/1.json
  def show
    @respuesta = Respuesta.find(params[:id])

    respond_to do |format|
      format.html # show.html.erb
      format.json { render json: @respuesta }
      format.xml { render xml: @respuesta }
    end
  end

  # GET /respuesta/new
  # GET /respuesta/new.json
  def new
    @respuestum = Respuestum.new

    respond_to do |format|
      format.html # new.html.erb
      format.json { render json: @respuestum }
    end
  end

  # GET /respuesta/1/edit
  def edit
    @respuestum = Respuestum.find(params[:id])
  end

  #GET /respuesta/1/estudiantes.xml
  def estudiantes
    @respuesta = Respuesta.find(params[:id]);
    @estudiantes = @respuesta.estudiante  

    respond_to do |format|      
      format.xml { render xml: @estudiantes}    
    end
  end

  # GET /respuesta
  def getrespuestas
  @prueba = Prueba.find(params[:prueba_id])
  @respuestas = @prueba.respuestas

  respond_to do |format|
      if @respuestas.empty?
        format.xml { head :no_content }
      else
        format.xml { render xml: @respuestas}
      end
    end
  end

  # POST /respuesta
  # POST /respuesta.json
  def create
    @respuesta = Respuesta.new
    @respuesta.estudiante_id = params[:estudiante_id]
    @respuesta.prueba_id = params[:prueba_id]
    @respuesta.respuesta = params[:respuesta]

    respond_to do |format|
      if @respuesta.save
        format.html { redirect_to @respuesta, notice: 'Respuestum was successfully created.' }
        format.json { render json: @respuesta }
      else
        format.html { render action: "new" }
        format.json { head :no_content }
      end
    end
  end

  # PUT /respuesta/1
  # PUT /respuesta/1.json
  def update
    @respuestum = Respuesta.find(params[:id])
    @respuestum.calificacion = params[:calificacion]
    respond_to do |format|
      if @respuestum.update_attributes(params[:respuestum])
        format.html { redirect_to @respuestum, notice: 'Respuestum was successfully updated.' }
        format.json { head :no_content }
      else
        format.html { render action: "edit" }
        format.json { render json: @respuestum.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /respuesta/1
  # DELETE /respuesta/1.json
  def destroy
    @respuestum = Respuestum.find(params[:id])
    @respuestum.destroy

    respond_to do |format|
      format.html { redirect_to respuesta_url }
      format.json { head :no_content }
    end
  end
end
