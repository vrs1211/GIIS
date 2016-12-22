Module Module1
    Public v As String = vbCrLf & "if (player1.tracking)" & vbCrLf &
"var.rightHand3dDist = sqrt( sqr(player1.rightshoulder.x-player1.righthand.x) + sqr(player1.rightshoulder.y-player1.righthand.y) +  sqr(player1.rightshoulder.z-player1.righthand.z) )" & vbCrLf &
"var.leftHand3dDist = sqrt( sqr(player1.leftshoulder.x-player1.lefthand.x) + sqr(player1.leftshoulder.y-player1.lefthand.y) +  sqr(player1.leftshoulder.z-player1.lefthand.z) )" & vbCrLf &
"if (var.rightHand3dDist > 55 cm && player1.right_arm_forwards > 35 cm)" & vbCrLf &
"if (!var.justIn)" & vbCrLf &
"var.firsInPosX = player1.head.x - player1.righthand.x" & vbCrLf &
"var.firsInPosY = player1.head.y - player1.righthand.y" & vbCrLf &
"var.firsInHandPosX = player1.righthand.x" & vbCrLf &
"var.firsInHandPosY = player1.righthand.y" & vbCrLf &
"var.justIn = true" & vbCrLf &
"mouse.CursorPosX = EnsureMapRange(-var.firsInPosX, -0.2, 0.5, 0, screen.Width)" & vbCrLf &
"mouse.CursorPosY = EnsureMapRange(var.firsInPosY, -0.1, 0.6, 0, screen.Height)" & vbCrLf &
"end if" & vbCrLf &
"var.Dx =   var.firsInHandPosX  - Smooth(player1.righthand.x , 5)" & vbCrLf &
"var.Dy =   var.firsInHandPosY  - Smooth(player1.righthand.y , 5)" & vbCrLf &
"mouse.DirectInputX += Delta(-var.Dx/7)" & vbCrLf &
"mouse.DirectInputY += Delta(var.Dy/7)" & vbCrLf &
"else" & vbCrLf &
"var.justIn = false" & vbCrLf &
   "end if" & vbCrLf &
  "if ( player1.left_arm_forwards > 25 cm )" & vbCrLf &
         "if (!var.justinClick)" & vbCrLf &
             "mouse.LeftButton = true" & vbCrLf &
             "wait 15ms" & vbCrLf &
             "mouse.LeftButton = false" & vbCrLf &
             "var.justinClick=true" & vbCrLf &
         "end if" & vbCrLf &
   "else if ( player1.left_arm_forwards < 25 cm )" & vbCrLf &
      "var.justinClick=false" & vbCrLf &
   "end if" & vbCrLf &
"if  (((player.head.y - player.leftwrist.y) > 0) && (player.head.y - player.leftwrist.y) < 0.05)" & vbCrLf &
         "if (!var.justin2Click)" & vbCrLf &
             "mouse.LeftButton = true" & vbCrLf &
             "wait 15ms" & vbCrLf &
             "mouse.LeftButton = false" & vbCrLf &
             "wait 15ms" & vbCrLf &
             "mouse.LeftButton = true" & vbCrLf &
             "wait 15ms" & vbCrLf &
             "mouse.LeftButton = false" & vbCrLf &
             "var.justin2Click=true" & vbCrLf &
         "end if" & vbCrLf &
   "else" & vbCrLf &
       "var.justin2Click=false" & vbCrLf &
   "end if" & vbCrLf &
   "if (player1.left_arm_out > 30 cm )" & vbCrLf &
          "mouse.LeftButton = true" & vbCrLf &
   "else" & vbCrLf &
        "mouse.LeftButton = false" & vbCrLf &
  "end if" & vbCrLf &
 "if ((player.hipcenter.z - player.leftwrist.z) > 0.2)" & vbCrLf &
"if (!var.justinRClick)" & vbCrLf &
             "mouse.RightButton = true" & vbCrLf &
             "wait 15ms" & vbCrLf &
             "mouse.RightButton = false" & vbCrLf &
             "var.justinRClick=true" & vbCrLf &
         "else" & vbCrLf &
         "var.justinRClick = false" & vbCrLf &
"end if" & vbCrLf &
"end if" & vbCrLf &
"end if"
End Module
