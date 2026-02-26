using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000970 RID: 2416
	[Token(Token = "0x2000970")]
	public class StoneParticlesOld : MonoBehaviour, IPoolElement<StoneParticlesOld>, IStoneParticles
	{
		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003981 RID: 14721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4B")]
		public ObjectPool<StoneParticlesOld> Pool
		{
			[Token(Token = "0x6003980")]
			[Address(RVA = "0x8911", Offset = "0x8911", VA = "0x8911", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003981")]
			[Address(RVA = "0x8912", Offset = "0x8912", VA = "0x8912", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x8913", Offset = "0x8913", VA = "0x8913")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_GameField_StoneParticlesOld__OnDestroy
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  float param1_00;
		  undefined8 local_80;
		  undefined8 local_78;
		  undefined8 local_70;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  int local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a56763 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		    DAT_ram_00a56763 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (DAT_ram_00a56759 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_StonesTypes__Color__TryGetValue__);
		    DAT_ram_00a56759 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__Color___TryAdd
		            (*(undefined4 *)(param3 + 0x10),param2,&local_10,
		             Method_System_Collections_Generic_Dictionary_StonesTypes__Color__TryGetValue__);
		  local_14 = param1[4];
		  local_48 = local_8;
		  local_50 = local_10;
		  UnityEngine_ParticleSystem_MinMaxGradient___ctor(&local_40,&local_50,0);
		  local_58 = local_18;
		  local_60 = local_20;
		  local_68 = local_28;
		  local_70 = local_30;
		  local_78 = local_38;
		  local_80 = local_40;
		  UnityEngine_ParticleSystem_MainModule___ctor(&local_14,&local_80,0);
		  UnityEngine_ParticleSystem__Play(param1[4],0);
		  param1_00 = (float)param1[5];
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply(uVar1,param1,*(undefined4 *)(*param1 + 0xf4),0);
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(param1_00,uVar1,1,0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,param2_00,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		  return;
		}
		*/

		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x8914", Offset = "0x8914", VA = "0x8914", Slot = "7")]
		public void SpawnParticles(StonesTypes stonesType, StoneMono.StoneSkinProvider provider)
		{
		/* --- GHIDRA: SpawnParticles ---
		void Gameplay_Combat_View_GameField_StoneParticlesOld__SpawnParticles(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a56764 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneParticlesOld__Release__);
		    DAT_ram_00a56764 = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    func_ii_7070(*(undefined4 *)(param1 + 0x18),param1,
		                 Method_Utils_Cache_ObjectPool_StoneParticlesOld__Release__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x8915", Offset = "0x8915", VA = "0x8915", Slot = "6")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		void Gameplay_Combat_View_GameField_StoneParticlesOld__Release(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 0x3f000000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x8916", Offset = "0x8916", VA = "0x8916")]
		public StoneParticlesOld()
		{
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x8917", Offset = "0x8917", VA = "0x8917", Slot = "8")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x8918", Offset = "0x8918", VA = "0x8918", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001FD5 RID: 8149
		[Token(Token = "0x4001FD5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04001FD6 RID: 8150
		[Token(Token = "0x4001FD6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _lifeDuration;

		// Token: 0x04001FD8 RID: 8152
		[Token(Token = "0x4001FD8")]
		[FieldOffset(Offset = "0x1C")]
		private bool _isDestroyed;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Pool ---
		void Gameplay_Combat_View_GameField_StoneParticlesOld__set_Pool(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined1 *)(param1 + 0x1c) = 1;
		  return;
		}
		*/

}
