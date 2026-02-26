using System;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001125 RID: 4389
	[Token(Token = "0x2001125")]
	public class GameTutorialV2 : AbstractGame
	{
		// Token: 0x060066C0 RID: 26304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066C0")]
		[Address(RVA = "0xB23F", Offset = "0xB23F", VA = "0xB23F", Slot = "69")]
		protected override void CreateGameManagers()
		{
		/* --- GHIDRA: CreateGameManagers ---
		void Core_Gameplay_GameTutorialV2__CreateGameManagers(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a905 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a5a905 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(param1_00,0);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066C1")]
		[Address(RVA = "0xB240", Offset = "0xB240", VA = "0xB240")]
		public GameTutorialV2()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_GameTutorialV2___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a92a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ITokenProvider___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__ITokenProvider__TypeInfo);
		    DAT_ram_00a5a92a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_string__ITokenProvider__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__ITokenProvider___ctor__)
		  ;
		  *(undefined4 *)(param1 + 8) = param1_00;
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}
	}
}
