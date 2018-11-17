import javax.swing.table.AbstractTableModel;
public class GornerTableModel  extends AbstractTableModel{
    private Double[] koeff;
    private Double from;
    private Double to;
    private Double step;

    public GornerTableModel(Double from,Double to, Double step,Double[] koeff){
        this.from = from;
        this.to = to;
        this.step = step;
        this.koeff = koeff;
    }

    public Double getFrom(){
        return from;
    }
    public Double getTo(){
        return to;
    }
    public Double getStep(){
        return step;
    }
    public int getColumnCount(){
        return 4;
    }
    public int getRowCount(){
        return new Double(Math.ceil((to - from)/step)).intValue() + 1;
    }

    public Object getValueAt(int row, int col) {
        double x = from + step * row;
        Double result = 0.0;
        switch (col)
        {
            case 0:
                // если запрашиваешь значение первого столбца, то значение только x
                return x;
            case 1:
                //Если запрашивается значение 2-го столбца, то это значение многочлена по схеме горнера
                result = 0.0;
                int n = koeff.length, i = koeff.length - 1;
                result += koeff[i-1] + x*koeff[i];
                /////////// Дописать Метод по схеме Горнера

                while(n > 1){
                    result *= x;
                    i--;
                    result += koeff[i];
                    n--;
                }
                return result;
            case 2:
                // Если запрашивается значение 3-го столбца, то это значение многочлена не по схеме горнера
                 result = koeff[0];
                 i = 1;
                 while(i < koeff.length){
                     result += koeff[i]*Math.pow(x,i);
                     i++;
                 }

                 return result;
            case 3:
                // Если запрашивается значение 4-го столбика, то это разница между схемой горнера и не схемой горнера
                result = Double.parseDouble(getValueAt(row,1).toString()) - Double.parseDouble(getValueAt(row, 2).toString());
                return result;
            default:
                return "Uncorrectable input";
        }

    }
    public String getColumnName (int col) {
        switch (col) {
            case 0:
                return "Значение Х";
            case 1:
                return "Значение многочлена по схеме Горнера";
            case 2:
                return "Значение многочлена по типу pow";
            case 3:
                return "Разница между схемой Горнера и по типу pow";
            default:
                return "Значение многочлена";
        }
    }

    public Class<?> getColunmClass (int col){
        return Double.class;
    }


}
