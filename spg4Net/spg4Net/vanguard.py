from sgp4.earth_gravity import wgs84
from sgp4.io import twoline2rv


class Vanguard(object):
    def calc(self):
      
        line1 = ('1 00005U 58002B   00179.78495062  '
                 '.00000023  00000-0  28098-4 0  4753')
        line2 = ('2 00005  34.2682 348.7242 1859667 '
                  '331.7664  19.3264 10.82419157413667')

        satellite = twoline2rv(line1, line2, wgs84)
        position, velocity = satellite.propagate(2000, 6, 29, 12, 50, 19)

        print(satellite.error)    # nonzero on error 0
        print(satellite.error_message) # None
        print(position)
        #print('5576.056952..., -3999.371134..., -1521.957159...')
        print(velocity)
        #print('4.772627..., 5.119817..., 4.275553...')