using System;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Dic;

namespace Gameplay.Combat.Model
{
	// Token: 0x0200099C RID: 2460
	[Token(Token = "0x200099C")]
	public class GameFieldGamesData
	{
		// Token: 0x06003ADA RID: 15066 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x8A4F", Offset = "0x8A4F", VA = "0x8A4F")]
		public float GetAnimationTimeByFieldChangeType(int type)
		{
		/* --- GHIDRA: GetAnimationTimeByFieldChangeType ---
		float Gameplay_Combat_Model_GameFieldGamesData__GetAnimationTimeByFieldChangeType
		                (undefined4 param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  
		  fVar1 = 0.2;
		  if (param2 != 2) {
		    fVar1 = 0.0;
		  }
		  return fVar1;
		}
		*/

		/* --- GHIDRA: GetAnimationTimeByFieldChangeType ---
		float Gameplay_Combat_Model_GameFieldGamesData__GetAnimationTimeByFieldChangeType
		                (undefined4 param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  
		  fVar1 = 0.2;
		  if (param2 != 2) {
		    fVar1 = 0.0;
		  }
		  return fVar1;
		}
		*/

			return 0f;
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x8A50", Offset = "0x8A50", VA = "0x8A50")]
		public float GetAnimationTimeByFieldChangeType(FieldChangedTypes type)
		{
			return 0f;
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x8A51", Offset = "0x8A51", VA = "0x8A51")]
		public float GetAnimationDelayByFieldChangeType(FieldChangedTypes type)
		{
			return 0f;
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADD")]
		[Address(RVA = "0x8A52", Offset = "0x8A52", VA = "0x8A52")]
		public GameFieldGamesData()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_Model_GameFieldGamesData___ctor
		               (int param1,undefined4 param2,undefined8 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  *(undefined4 *)(param1 + 0x20) = param6;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined8 *)(param1 + 0x10) = param3;
		  *(undefined1 *)(param1 + 8) = (undefined1)param2;
		  return;
		}
		*/

		}

		// Token: 0x0400207D RID: 8317
		[Token(Token = "0x400207D")]
		[FieldOffset(Offset = "0x8")]
		public GameFieldGemSetsDic Gems;

		// Token: 0x0400207E RID: 8318
		[Token(Token = "0x400207E")]
		[FieldOffset(Offset = "0xC")]
		public CombatTypeGemSetsDic TypeGemSet;

		// Token: 0x0400207F RID: 8319
		[Token(Token = "0x400207F")]
		[FieldOffset(Offset = "0x10")]
		public uint XSize;

		// Token: 0x04002080 RID: 8320
		[Token(Token = "0x4002080")]
		[FieldOffset(Offset = "0x14")]
		public uint YSize;

		// Token: 0x04002081 RID: 8321
		[Token(Token = "0x4002081")]
		public const float DESTROY_DURATION = 0.3f;

		// Token: 0x04002082 RID: 8322
		[Token(Token = "0x4002082")]
		public const float SHIFТ_AFTER_DESTROY_DURATION = 0.3f;
	}
}
