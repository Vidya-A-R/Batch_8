class GameController {
	private GameStatus _gameStatus;
	private IPlayer _player;
	
	//start dari status belum initialized kah?
	public GameController() {
		_gameStatus = GameStatus.NotInitialized;
	}
	
	//terdapat AddPlayer yang berfungsi untuk menambahkan player ketika game belum terinisialiasi(?)
	//atau gimana aku lupa tadi urutannya ya pokoknya gitu lah
	public bool AddPlayer(IPlayer player) {
		//jadi setelah method AddPlayer dipanggil maka status player menjadi tidak null lagi
		if(_player is null) {
			return false;
		}
		//ini ketika game sudah ready atau game sudah mulai main maka tidak bisa add player lagi
		if(_gameStatus is not GameStatus.NotInitialized) {
			return false;
		}
		//
		_player = player;
		_gameStatus = GameStatus.Ready;
		return true;
	}
	public GameStatus CheckGame() {
		return _gameStatus;
	}
	public bool StartGame() {
		if(_gameStatus is not GameStatus.Ready) {
			return false;
		}
		_gameStatus = GameStatus.Playing;
		return true;
	}
}
public enum GameStatus {
	NotInitialized,
	Ready,
	Playing,
}
public interface IPlayer {
	public int ID {get;}
	public string Name {get;}
}

class Program
{
	static void Main()
	{
		GameController gameController = new GameController();
		FirstStepChecker(gameController.CheckGame);
	}
	
	static void FirstStepChecker(gameController)
	{
		
	}
}
