using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.View.Fx
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	public class SnowFxView : MonoBehaviour
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x65AC", Offset = "0x65AC", VA = "0x65AC")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		undefined4 Gameplay_World_View_Fx_SnowFxView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x14;
		  if (*(char *)(param1 + 0x20) == '\0') {
		    iVar1 = 0x10;
		  }
		  return *(undefined4 *)(param1 + iVar1);
		}
		*/

		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000312")]
		private ParticleSystem CurrentParticles
		{
			[Token(Token = "0x60013BE")]
			[Address(RVA = "0x65AD", Offset = "0x65AD", VA = "0x65AD")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x65AE", Offset = "0x65AE", VA = "0x65AE")]
		public void Show(bool windy)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_World_View_Fx_SnowFxView__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  iVar1 = 0x14;
		  if (*(char *)(param1 + 0x20) == '\0') {
		    iVar1 = 0x10;
		  }
		  local_4 = *(undefined4 *)(param1 + iVar1);
		  UnityEngine_ParticleSystem_EmissionModule___ctor(&local_4,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x65AF", Offset = "0x65AF", VA = "0x65AF")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_World_View_Fx_SnowFxView__Hide(int param1,float *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  iVar1 = 0x14;
		  if (*(char *)(param1 + 0x20) == '\0') {
		    iVar1 = 0x10;
		  }
		  local_4 = *(undefined4 *)(param1 + iVar1);
		  iVar1 = 0x1c;
		  if (*(char *)(param1 + 0x20) == '\0') {
		    iVar1 = 0x18;
		  }
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve
		            (&local_1c,*(float *)(param1 + iVar1) + *param2 * -0.25,0);
		  local_40 = local_c;
		  local_48 = local_14;
		  local_50 = local_1c;
		  UnityEngine_ParticleSystem_VelocityOverLifetimeModule__get_x(&local_4,&local_50,0);
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve(&local_34,param2[2] / 10.0,0);
		  local_58 = local_24;
		  local_60 = local_2c;
		  local_68 = local_34;
		  UnityEngine_ParticleSystem_VelocityOverLifetimeModule__set_xBlittable(&local_4,&local_68,0);
		  return;
		}
		*/

		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x65B0", Offset = "0x65B0", VA = "0x65B0")]
		public void OnCameraMoved(Vector3 pos)
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x65B1", Offset = "0x65B1", VA = "0x65B1")]
		public SnowFxView()
		{
		}

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ParticleSystem _particlesDefault;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _particlesWindy;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x18")]
		private float _defaultX;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x1C")]
		private float _windyX;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x20")]
		private bool _isWindyNow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentParticles ---
		void Gameplay_World_View_Fx_SnowFxView__get_CurrentParticles
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  *(char *)(param1 + 0x20) = (char)param2;
		  iVar1 = 0x14;
		  if (param2 == 0) {
		    iVar1 = 0x10;
		  }
		  local_4 = *(undefined4 *)(param1 + iVar1);
		  UnityEngine_ParticleSystem_EmissionModule___ctor(&local_4,1,0);
		  return;
		}
		*/

}
