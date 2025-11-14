using UnityEngine; 
using TMPro; // Import TextMeshPro library 
public class ScoreManager : MonoBehaviour 
{ 
// Assign the TextMeshPro UI element in the Inspector 
public TextMeshProUGUI scoreText; 
// Keep track of the current score 
private int currentScore = 0; 
void Start() 
{ 
} 
// Set the initial score text 
UpdateScoreText(); 
// This is a public function that other scripts (like Bullet.cs) can call 
public void AddPoint() 
{ 
currentScore++; 
UpdateScoreText(); 
} 
// A private function to update the UI 
private void UpdateScoreText() 
{ 
} 
} 
scoreText.text = "Score: " + currentScore.ToString();
