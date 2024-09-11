# Q1

## Bullet With Particles Explosion

### Setup
Setup is done as asked in the question.
    - walls and floors are added with appropiate materials.
    - Bullet is made using Sphere and Particle is made using Cubes
    - For explosion total n particles are spawned then a explosion force is added to each particle.
    - bullet is fired towards wall using rigidbody and forcemode acceleration.
### Scripts
    - **Bullet**: attached to bullet object, adds a acclearation to attached rigidbody object when spawned.
    - **Exploder**: takes multiple particles prefabs, then when instantiated make multiple copies of these particle and add explosive force to them.
    - **LifeSpan**: This script puts a lifespan with little variance in value to attached object, once time crosses lifespan it destroys the object.
    - **Shooter**: This script is responsible for reading user input and then instantiating a bullet.

---

# Q2

## installing ml-agents

- a. Downloaded and extracted the file form github.
- b, c. v-env created using anaconda ```conda create -n mlagents``` and activated using ```conda activate mlagents```.
- d. pytorch installed using the command generated using the gui on pytorch homepage that is ```pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu124```.
- e.  both the packages are installed using pip, there was error building numpy package so it was installed using conda.
- f. remaining packages to be added to unity are added using unity package manager.