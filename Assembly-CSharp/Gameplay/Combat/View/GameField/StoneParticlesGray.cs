using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200096F RID: 2415
	[Token(Token = "0x200096F")]
	public class StoneParticlesGray : MonoBehaviour, IPoolElement<StoneParticlesGray>, IStoneParticles
	{
		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4A")]
		public ObjectPool<StoneParticlesGray> Pool
		{
			[Token(Token = "0x6003978")]
			[Address(RVA = "0x8909", Offset = "0x8909", VA = "0x8909", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003979")]
			[Address(RVA = "0x890A", Offset = "0x890A", VA = "0x890A", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x890B", Offset = "0x890B", VA = "0x890B")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_GameField_StoneParticlesGray__OnDestroy
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float param1_00;
		  
		  if (DAT_ram_00a56761 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_ParticleSystemRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_MaterialPropertyBlock_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		    Mono_Security_ASN1__get_Item(&Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    DAT_ram_00a56761 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1[4],Method_UnityEngine_Component_GetComponent_ParticleSystemRenderer___
		                      );
		  Gameplay_Combat_View_GameField_StoneMono_StoneSkinProvider__GetColor(param3,param2,uVar1,param1);
		  uVar2 = unnamed_function_1417(UnityEngine_MaterialPropertyBlock_TypeInfo);
		  UnityEngine_MaterialPropertyBlock__SetVectorArray(uVar2,0);
		  UnityEngine_Renderer__SetPropertyBlock(uVar1,uVar2,0);
		  if (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		  }
		  UnityEngine_MaterialPropertyBlock__Dispose
		            (uVar2,*(undefined4 *)
		                    (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c) + 4),1.0,
		             0);
		  UnityEngine_Renderer__HasPropertyBlock(uVar1,uVar2,0);
		  UnityEngine_ParticleSystem__Play(param1[4],0);
		  param1_00 = (float)param1[5];
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply(uVar1,param1,*(undefined4 *)(*param1 + 0xf4),0);
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(param1_00,uVar1,1,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,uVar2,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		  return;
		}
		*/

		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x890C", Offset = "0x890C", VA = "0x890C", Slot = "7")]
		public void SpawnParticles(StonesTypes stonesType, StoneMono.StoneSkinProvider provider)
		{
		/* --- GHIDRA: SpawnParticles ---
		void Gameplay_Combat_View_GameField_StoneParticlesGray__SpawnParticles(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a56762 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneParticlesGray__Release__);
		    DAT_ram_00a56762 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_7070(*(int *)(param1 + 0x18),param1,
		                 Method_Utils_Cache_ObjectPool_StoneParticlesGray__Release__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x890D", Offset = "0x890D", VA = "0x890D", Slot = "6")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		void Gameplay_Combat_View_GameField_StoneParticlesGray__Release(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 0x3f800000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600397D RID: 14717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x890E", Offset = "0x890E", VA = "0x890E")]
		public StoneParticlesGray()
		{
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x890F", Offset = "0x890F", VA = "0x890F", Slot = "8")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x8910", Offset = "0x8910", VA = "0x8910", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001FD2 RID: 8146
		[Token(Token = "0x4001FD2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04001FD3 RID: 8147
		[Token(Token = "0x4001FD3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _lifeDuration;
	}
}
