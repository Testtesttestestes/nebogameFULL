using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200096E RID: 2414
	[Token(Token = "0x200096E")]
	public class StoneParticles : MonoBehaviour, IPoolElement<StoneParticles>, IStoneParticles
	{
		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003971 RID: 14705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B49")]
		public ObjectPool<StoneParticles> Pool
		{
			[Token(Token = "0x6003970")]
			[Address(RVA = "0x8901", Offset = "0x8901", VA = "0x8901", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003971")]
			[Address(RVA = "0x8902", Offset = "0x8902", VA = "0x8902", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x8903", Offset = "0x8903", VA = "0x8903")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_GameField_StoneParticles__OnDestroy
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float param1_00;
		  undefined8 local_160;
		  undefined8 local_158;
		  undefined8 local_150;
		  undefined8 local_148;
		  undefined8 local_140;
		  undefined4 local_138;
		  undefined8 local_130;
		  undefined8 local_128;
		  undefined8 local_120;
		  undefined8 local_118;
		  undefined8 local_110;
		  undefined8 local_108;
		  undefined8 local_100;
		  undefined4 local_f8;
		  undefined8 local_f0;
		  undefined8 local_e8;
		  undefined8 local_e0;
		  undefined8 local_d8;
		  undefined8 local_d0;
		  undefined8 local_c8;
		  undefined8 local_c0;
		  undefined4 local_b8;
		  undefined8 local_b0;
		  undefined8 local_a8;
		  undefined8 local_a0;
		  undefined8 local_98;
		  undefined8 local_90;
		  undefined8 local_88;
		  undefined8 local_80;
		  undefined4 local_78;
		  undefined8 local_74;
		  undefined8 local_6c;
		  undefined8 local_64;
		  undefined8 local_5c;
		  undefined8 local_54;
		  undefined4 local_4c;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  int local_1c;
		  int local_18;
		  int local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5675f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_ParticleSystemRenderer___);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		    DAT_ram_00a5675f = '\x01';
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
		  uVar1 = func_ii_5677(param1[9],Method_UnityEngine_Component_GetComponent_ParticleSystemRenderer___
		                      );
		  uVar2 = func_ii_5677(param1[4],Method_UnityEngine_Component_GetComponent_ParticleSystemRenderer___
		                      );
		  Gameplay_Combat_View_GameField_StoneMono_StoneSkinProvider__SetupShardsMaterialProps
		            (param3,param2,uVar1,&local_160);
		  Gameplay_Combat_View_GameField_StoneMono_StoneSkinProvider__GetColor
		            (param3,param2,uVar2,&local_160);
		  local_14 = param1[9];
		  local_a8 = local_8;
		  local_b0 = local_10;
		  UnityEngine_ParticleSystem_MinMaxGradient___ctor(&local_48,&local_b0,0);
		  local_b8 = local_20;
		  local_c0 = local_28;
		  local_c8 = local_30;
		  local_d0 = local_38;
		  local_d8 = local_40;
		  local_e0 = local_48;
		  UnityEngine_ParticleSystem_MainModule___ctor(&local_14,&local_e0,0);
		  local_18 = param1[5];
		  local_e8 = local_8;
		  local_f0 = local_10;
		  UnityEngine_ParticleSystem_MinMaxGradient___ctor(&local_74,&local_f0,0);
		  local_f8 = local_4c;
		  local_100 = local_54;
		  local_108 = local_5c;
		  local_110 = local_64;
		  local_118 = local_6c;
		  local_120 = local_74;
		  UnityEngine_ParticleSystem_MainModule___ctor(&local_18,&local_120,0);
		  local_1c = param1[7];
		  local_128 = local_8;
		  local_130 = local_10;
		  UnityEngine_ParticleSystem_MinMaxGradient___ctor(&local_a0,&local_130,0);
		  local_138 = local_78;
		  local_140 = local_80;
		  local_148 = local_88;
		  local_150 = local_90;
		  local_158 = local_98;
		  local_160 = local_a0;
		  UnityEngine_ParticleSystem_MainModule___ctor(&local_1c,&local_160,0);
		  UnityEngine_ParticleSystem__Play(param1[4],0);
		  UnityEngine_ParticleSystem__Play(param1[5],0);
		  UnityEngine_ParticleSystem__Play(param1[6],0);
		  UnityEngine_ParticleSystem__Play(param1[7],0);
		  UnityEngine_ParticleSystem__Play(param1[8],0);
		  UnityEngine_ParticleSystem__Play(param1[9],0);
		  param1_00 = (float)param1[10];
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

		// Token: 0x06003973 RID: 14707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x8904", Offset = "0x8904", VA = "0x8904", Slot = "7")]
		public void SpawnParticles(StonesTypes stonesType, StoneMono.StoneSkinProvider provider)
		{
		/* --- GHIDRA: SpawnParticles ---
		void Gameplay_Combat_View_GameField_StoneParticles__SpawnParticles(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a56760 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneParticles__Release__);
		    DAT_ram_00a56760 = '\x01';
		  }
		  if (*(char *)(param1 + 0x30) == '\0') {
		    func_ii_7070(*(undefined4 *)(param1 + 0x2c),param1,
		                 Method_Utils_Cache_ObjectPool_StoneParticles__Release__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x8905", Offset = "0x8905", VA = "0x8905", Slot = "6")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		void Gameplay_Combat_View_GameField_StoneParticles__Release(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x28) = 0x3f000000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x8906", Offset = "0x8906", VA = "0x8906")]
		public StoneParticles()
		{
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x8907", Offset = "0x8907", VA = "0x8907", Slot = "8")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x8908", Offset = "0x8908", VA = "0x8908", Slot = "9")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ParticleSystem _shards;

		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _particles;

		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _particles2;

		// Token: 0x04001FCC RID: 8140
		[Token(Token = "0x4001FCC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ParticleSystem _whiteSmoke;

		// Token: 0x04001FCD RID: 8141
		[Token(Token = "0x4001FCD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _waves;

		// Token: 0x04001FCE RID: 8142
		[Token(Token = "0x4001FCE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ParticleSystem _outline;

		// Token: 0x04001FCF RID: 8143
		[Token(Token = "0x4001FCF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _duration;

		// Token: 0x04001FD1 RID: 8145
		[Token(Token = "0x4001FD1")]
		[FieldOffset(Offset = "0x30")]
		private bool _isDestroyed;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Pool ---
		void Gameplay_Combat_View_GameField_StoneParticles__set_Pool(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  *(undefined1 *)(param1 + 0x30) = 1;
		  return;
		}
		*/

}
