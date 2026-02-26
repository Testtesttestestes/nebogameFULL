using System;
using DG.Tweening;
using Il2CppDummyDll;

namespace Gameplay.Tutorial.Guide.View.Spin
{
	// Token: 0x02000468 RID: 1128
	[Token(Token = "0x2000468")]
	public class RectangleSpin : AbstractSpin
	{
		// Token: 0x06001AC7 RID: 6855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x6C54", Offset = "0x6C54", VA = "0x6C54", Slot = "5")]
		public override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Tutorial_Guide_View_Spin_RectangleSpin__Start(int param1,undefined4 param2)
		
		{
		  func_ii_7891(*(undefined4 *)(param1 + 0x18),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x6C55", Offset = "0x6C55", VA = "0x6C55", Slot = "6")]
		public override void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_Tutorial_Guide_View_Spin_RectangleSpin__Stop(int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,*(undefined4 *)(*param1 + 0xf4));
		  param1[6] = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x6C56", Offset = "0x6C56", VA = "0x6C56", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tutorial_Guide_View_Spin_RectangleSpin__Dispose(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 8) = 0x7fffffff40000000;
		  return;
		}
		*/

		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x6C57", Offset = "0x6C57", VA = "0x6C57")]
		public RectangleSpin()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Spin_RectangleSpin___ctor
		               (int param1,float param2,undefined4 param3)
		
		{
		  float *pfVar1;
		  int iVar2;
		  float *pfVar3;
		  float *pfVar4;
		  float *pfVar5;
		  float *pfVar6;
		  float *pfVar7;
		  float *pfVar8;
		  int iVar9;
		  float fVar10;
		  float fVar11;
		  undefined8 local_18;
		  undefined4 local_10;
		  float4 local_c;
		  float4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5845f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2___TypeInfo);
		    DAT_ram_00a5845f = '\x01';
		  }
		  iVar9 = **(int **)(param1 + 0x14);
		  iVar9 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0xe8) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar9 + 0xec));
		  iVar2 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector2___TypeInfo,4);
		  pfVar3 = (float *)(iVar2 + 0x10);
		  *(undefined8 *)pfVar3 = *(undefined8 *)(iVar9 + 0x10);
		  pfVar4 = (float *)(iVar2 + 0x18);
		  *(undefined8 *)pfVar4 = *(undefined8 *)(iVar9 + 0x18);
		  pfVar5 = (float *)(iVar2 + 0x20);
		  *(undefined8 *)pfVar5 = *(undefined8 *)(iVar9 + 0x20);
		  pfVar6 = (float *)(iVar2 + 0x28);
		  *(undefined8 *)pfVar6 = *(undefined8 *)(iVar9 + 0x28);
		  if (param2 < 1.0) {
		    pfVar7 = (float *)(iVar2 + 0x14);
		    pfVar8 = (float *)(iVar2 + 0x1c);
		    pfVar1 = pfVar3;
		  }
		  else if ((param2 <= 1.0) || (2.0 <= param2)) {
		    if ((param2 <= 2.0) || (3.0 <= param2)) {
		      param2 = param2 + -3.0;
		      pfVar7 = (float *)(iVar2 + 0x2c);
		      pfVar8 = (float *)(iVar2 + 0x14);
		      pfVar1 = pfVar6;
		      pfVar4 = pfVar3;
		    }
		    else {
		      param2 = param2 + -2.0;
		      pfVar7 = (float *)(iVar2 + 0x24);
		      pfVar8 = (float *)(iVar2 + 0x2c);
		      pfVar1 = pfVar5;
		      pfVar4 = pfVar6;
		    }
		  }
		  else {
		    param2 = param2 + -1.0;
		    pfVar7 = (float *)(iVar2 + 0x1c);
		    pfVar8 = (float *)(iVar2 + 0x24);
		    pfVar1 = pfVar4;
		    pfVar4 = pfVar5;
		  }
		  local_4 = 0;
		  local_10 = 0;
		  fVar11 = 1.0;
		  if (param2 <= 1.0) {
		    fVar11 = param2;
		  }
		  fVar10 = 0.0;
		  if (0.0 <= param2) {
		    fVar10 = fVar11;
		  }
		  local_8 = (float4)(*pfVar7 + fVar10 * (*pfVar8 - *pfVar7));
		  local_c = (float4)(*pfVar1 + fVar10 * (*pfVar4 - *pfVar1));
		  local_18 = CONCAT44(local_8,local_c);
		  UnityEngine_Transform__get_position(*(undefined4 *)(param1 + 0x10),&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x18")]
		private Tween _tween;
	}
}
