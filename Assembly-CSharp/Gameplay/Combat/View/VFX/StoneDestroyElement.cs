using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Animations;
using DG.Tweening;
using Gameplay.Combat.Control;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.Players.Pet;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using UnityEngine.UI;
using Utils.Cache;

namespace Gameplay.Combat.View.VFX
{
	// Token: 0x0200092A RID: 2346
	[Token(Token = "0x200092A")]
	public class StoneDestroyElement : MonoBehaviour, CombatAnimation.IContent, IDisposable, IConveyorItem, IPoolElement<StoneDestroyElement>
	{
		// Token: 0x14000177 RID: 375
		// (add) Token: 0x06003746 RID: 14150 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003747 RID: 14151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000177")]
		public event Action<CombatAnimation.IContent> OnCompleteEvent
		{
			[Token(Token = "0x6003746")]
			[Address(RVA = "0x8734", Offset = "0x8734", VA = "0x8734", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003747")]
			[Address(RVA = "0x8735", Offset = "0x8735", VA = "0x8735", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AEA")]
		public Transform Transform
		{
			[Token(Token = "0x6003748")]
			[Address(RVA = "0x8736", Offset = "0x8736", VA = "0x8736", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x17000AEB")]
		public StonesTypes Stone
		{
			[Token(Token = "0x6003749")]
			[Address(RVA = "0x8737", Offset = "0x8737", VA = "0x8737")]
			get
			{
				return StonesTypes.Empty;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0000B160 File Offset: 0x00009360
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEC")]
		public float Duration
		{
			[Token(Token = "0x600374A")]
			[Address(RVA = "0x8738", Offset = "0x8738", VA = "0x8738", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600374B")]
			[Address(RVA = "0x8739", Offset = "0x8739", VA = "0x8739")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x0000B178 File Offset: 0x00009378
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AED")]
		public float Delay
		{
			[Token(Token = "0x600374C")]
			[Address(RVA = "0x873A", Offset = "0x873A", VA = "0x873A", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600374D")]
			[Address(RVA = "0x873B", Offset = "0x873B", VA = "0x873B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x0000B190 File Offset: 0x00009390
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEE")]
		public bool IsLeft
		{
			[Token(Token = "0x600374E")]
			[Address(RVA = "0x873C", Offset = "0x873C", VA = "0x873C", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600374F")]
			[Address(RVA = "0x873D", Offset = "0x873D", VA = "0x873D", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEF")]
		public ObjectPool<StoneDestroyElement> Pool
		{
			[Token(Token = "0x6003750")]
			[Address(RVA = "0x873E", Offset = "0x873E", VA = "0x873E", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003751")]
			[Address(RVA = "0x873F", Offset = "0x873F", VA = "0x873F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x17000AF0")]
		private bool IsSkull
		{
			[Token(Token = "0x6003752")]
			[Address(RVA = "0x8740", Offset = "0x8740", VA = "0x8740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x8741", Offset = "0x8741", VA = "0x8741")]
		private void Awake()
		{
		/* --- GHIDRA: <PlayCor>b__68_0 ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement___PlayCor_b__68_0(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a566b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a566b7 = '\x01';
		  }
		  param1_00 = func_ii_9125(*(undefined4 *)(param1 + 0x1c),0.0,*(float *)(param1 + 0x68) * 0.5,0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (param1_00,param2_00,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		            );
		  return;
		}
		*/

		/* --- GHIDRA: Awake ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Awake
		               (int param1,undefined8 *param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined8 *)(param1 + 0x94) = *param2;
		  *(undefined4 *)(param1 + 0x9c) = *(undefined4 *)(param2 + 1);
		  *(undefined8 *)(param1 + 0xa0) = 0;
		  *(undefined1 *)(param1 + 0x8c) = (undefined1)param3;
		  *(undefined4 *)(param1 + 0x88) = *(undefined4 *)(param1 + 0x60);
		  *(float *)(param1 + 0x84) =
		       *(float *)(param1 + 100) + *(float *)(param1 + 0x68) + *(float *)(param1 + 0x70);
		  return;
		}
		*/

		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x8742", Offset = "0x8742", VA = "0x8742")]
		public void Init(Vector3 position, bool isMyTurn)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a566ad == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566ad = '\x01';
		  }
		  Gameplay_Combat_View_VFX_StoneDestroyElement__Play(param1,param1);
		  uVar4 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		  if (iVar2 != 0) {
		    local_8 = *(undefined4 *)(param1 + 0x9c);
		    local_10 = *(undefined8 *)(param1 + 0x94);
		    UnityEngine_Transform__get_position(*(undefined4 *)(param1 + 0x2c),&local_10,0);
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		  if (iVar2 != 0) {
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x18),0);
		    local_18 = *(undefined4 *)(param1 + 0x9c);
		    local_20 = *(undefined8 *)(param1 + 0x94);
		    UnityEngine_Transform__get_position(uVar4,&local_20,0);
		  }
		  param1_00 = *(int **)(param1 + 0x20);
		  if (DAT_ram_00a566b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		    DAT_ram_00a566b4 = '\x01';
		  }
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80c641e1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x80c641e1:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    UnityEngine_Object__op_Implicit(uVar4,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x8743", Offset = "0x8743", VA = "0x8743", Slot = "6")]
		public void Show()
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Show(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a566af == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		    DAT_ram_00a566af = '\x01';
		  }
		  func_ii_7070(*(undefined4 *)(param1 + 0xa8),param1,
		               Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		  Gameplay_Combat_View_VFX_StoneDestroyElement__Play(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003756 RID: 14166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003756")]
		[Address(RVA = "0x8744", Offset = "0x8744", VA = "0x8744", Slot = "7")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Hide
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		    DAT_ram_00a566b1 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		  *(int *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  *(undefined4 *)(param1 + 0x90) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003757")]
		[Address(RVA = "0x8745", Offset = "0x8745", VA = "0x8745", Slot = "8")]
		public void Play(bool _)
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Play(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a566af == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		    DAT_ram_00a566af = '\x01';
		  }
		  func_ii_7070(*(undefined4 *)(param1 + 0xa8),param1,
		               Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		  Gameplay_Combat_View_VFX_StoneDestroyElement__Play(param1,param1);
		  *(undefined4 *)(param1 + 0xa8) = 0;
		  return;
		}
		*/

		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Play(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a566af == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		    DAT_ram_00a566af = '\x01';
		  }
		  func_ii_7070(*(undefined4 *)(param1 + 0xa8),param1,
		               Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		  Gameplay_Combat_View_VFX_StoneDestroyElement__Play(param1,param1);
		  *(undefined4 *)(param1 + 0xa8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003758")]
		[Address(RVA = "0x8746", Offset = "0x8746", VA = "0x8746", Slot = "12")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a566ae == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566ae = '\x01';
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x18),param2,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param2_00 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param3,0,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x1c),param2_00,0);
		  if (param2_00 != 0) {
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x8747", Offset = "0x8747", VA = "0x8747")]
		public void SetSkin(Sprite skin, Sprite glow)
		{
		/* --- GHIDRA: SetSkin ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__SetSkin
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  if (*(longlong *)(param1 + 0xa0) == 0) {
		    *(undefined8 *)(param1 + 0xa0) = param2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x8748", Offset = "0x8748", VA = "0x8748")]
		public void SetCount(long count)
		{
		/* --- GHIDRA: SetCount ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__SetCount(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a566af == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		    DAT_ram_00a566af = '\x01';
		  }
		  func_ii_7070(*(undefined4 *)(param1 + 0xa8),param1,
		               Method_Utils_Cache_ObjectPool_StoneDestroyElement__Release__);
		  return;
		}
		*/

		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x8749", Offset = "0x8749", VA = "0x8749", Slot = "17")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__Release(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		    DAT_ram_00a566b1 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		  *(int *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  *(undefined4 *)(param1 + 0x90) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x874A", Offset = "0x874A", VA = "0x874A")]
		private void Play()
		{
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x874B", Offset = "0x874B", VA = "0x874B")]
		private void ResetAll()
		{
		/* --- GHIDRA: ResetAll ---
		int Gameplay_Combat_View_VFX_StoneDestroyElement__ResetAll(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a566b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		    DAT_ram_00a566b1 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x874C", Offset = "0x874C", VA = "0x874C")]
		private IEnumerator PlayCor()
		{
		/* --- GHIDRA: PlayCor ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor
		               (int param1,undefined4 *param2,undefined4 *param3,undefined4 param4)
		
		{
		  char cVar1;
		  bool bVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a566b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566b2 = '\x01';
		  }
		  cVar1 = *(char *)(param1 + 0x8c);
		  if (*(int *)(param1 + 0x10) == 4) {
		    iVar5 = 0x4c;
		    if (cVar1 == '\0') {
		      iVar5 = 0x48;
		    }
		    iVar5 = *(int *)(param1 + iVar5);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    bVar2 = true;
		    iVar3 = UnityEngine_Component__GetComponent_object_(iVar5,0);
		    if ((iVar3 != 0) && (*(char *)(iVar5 + 0x14) != '\0')) {
		      bVar2 = *(char *)(iVar5 + 0x1c) != '\0';
		    }
		    if (*(char *)(param1 + 0x8c) == '\0') {
		      iVar5 = 0x40;
		      if (!bVar2) {
		        iVar5 = 0x58;
		      }
		      *param2 = *(undefined4 *)(param1 + iVar5);
		      puVar4 = (undefined4 *)(param1 + 0x38);
		      if (!bVar2) {
		        puVar4 = (undefined4 *)(param1 + 0x50);
		      }
		    }
		    else {
		      iVar5 = 0x44;
		      if (!bVar2) {
		        iVar5 = 0x5c;
		      }
		      *param2 = *(undefined4 *)(param1 + iVar5);
		      puVar4 = (undefined4 *)(param1 + 0x3c);
		      if (!bVar2) {
		        puVar4 = (undefined4 *)(param1 + 0x54);
		      }
		    }
		  }
		  else {
		    iVar5 = 0x40;
		    if (cVar1 == '\0') {
		      iVar5 = 0x44;
		    }
		    *param2 = *(undefined4 *)(param1 + iVar5);
		    puVar4 = (undefined4 *)(param1 + 0x38);
		    if (cVar1 == '\0') {
		      puVar4 = (undefined4 *)(param1 + 0x3c);
		    }
		  }
		  *param3 = *puVar4;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x874D", Offset = "0x874D", VA = "0x874D")]
		private void GetTargets(out Transform target, out Transform animationTarget)
		{
		/* --- GHIDRA: GetTargets ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__GetTargets
		               (int param1,int param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  float param3_00;
		  float param2_01;
		  
		  if (DAT_ram_00a566b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_VFX_StoneDestroyElement_SetAlpha__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		    DAT_ram_00a566b3 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 == 0) {
		    uVar2 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		    DG_Tweening_Core_DOSetter_Rect___Invoke
		              (uVar2,param1,Method_Gameplay_Combat_View_VFX_StoneDestroyElement_SetAlpha__,0);
		    param3_00 = 1.0;
		    if (param2 == 0) {
		      param3_00 = 0.0;
		    }
		    param2_01 = 0.0;
		    if (param2 == 0) {
		      param2_01 = 1.0;
		    }
		    if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		      func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		    }
		    uVar2 = DG_Tweening_DOTween__ToAlpha(uVar2,param2_01,param3_00,param3,0);
		    param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x24),0);
		    DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		              (uVar2,param2_00,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x874E", Offset = "0x874E", VA = "0x874E")]
		private void FadeAnimation(bool enable, float duration)
		{
		/* --- GHIDRA: FadeAnimation ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__FadeAnimation
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a566b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		    DAT_ram_00a566b4 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80c64295;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x80c64295:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    UnityEngine_Object__op_Implicit(param1_00,param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x874F", Offset = "0x874F", VA = "0x874F")]
		private void SetAnimationEnabled(ISkeletonGraphicProvider uiAnimation, bool enable)
		{
		/* --- GHIDRA: SetAnimationEnabled ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__SetAnimationEnabled
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a566b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566b5 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(param1_00,0,0);
		  if (iVar1 == 0) {
		    piVar2 = (int *)DG_Tweening_TweenSettingsExtensions__SetLink_object_
		                              (*(undefined4 *)(param1 + 0x24),0);
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x170) * 4))
		              (&local_10,piVar2,*(undefined4 *)(*piVar2 + 0x174));
		    local_18 = local_8;
		    local_20 = local_10;
		    piVar2 = (int *)DG_Tweening_TweenSettingsExtensions__SetLink_object_
		                              (*(undefined4 *)(param1 + 0x24),0);
		    local_8 = local_18;
		    local_10 = local_20;
		    local_28 = CONCAT44(param2,local_18);
		    local_30 = local_20;
		    local_4 = (float4)param2;
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x178) * 4))
		              (piVar2,&local_30,*(undefined4 *)(*piVar2 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003762")]
		[Address(RVA = "0x8750", Offset = "0x8750", VA = "0x8750")]
		private void SetAlpha(float value)
		{
		/* --- GHIDRA: SetAlpha ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__SetAlpha(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  Gameplay_Combat_View_VFX_StoneDestroyElement__Init(param1,param1);
		  if (DAT_ram_00a566b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		    DAT_ram_00a566b1 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_d__68_TypeInfo);
		  *(int *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  *(undefined4 *)(param1 + 0x90) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x8751", Offset = "0x8751", VA = "0x8751")]
		public void TestPlay()
		{
		/* --- GHIDRA: TestPlay ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__TestPlay(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x7c) = 2;
		  *(undefined8 *)(param1 + 0x74) = 0x300000002;
		  *(undefined1 *)(param1 + 0x14) = 1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x8752", Offset = "0x8752", VA = "0x8752")]
		public StoneDestroyElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a566b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_b__68_1__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a566b6 = '\x01';
		  }
		  uVar1 = func_ii_9125(*(undefined4 *)(param1 + 0x1c),1.0,*(float *)(param1 + 0x68) * 0.5,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,uVar2,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		                    );
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar2,param1,Method_Gameplay_Combat_View_VFX_StoneDestroyElement__PlayCor_b__68_1__,0);
		  DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar1,uVar2,
		             Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StonesTypes _stone;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool _flipForRight;

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x15")]
		[SerializeField]
		private bool _scaleToTarget;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _skin;

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _glow;

		// Token: 0x04001E6F RID: 7791
		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameSpineUiAnimation _back;

		// Token: 0x04001E70 RID: 7792
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameSpineUiAnimation _animation;

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSpineUiAnimation _finish;

		// Token: 0x04001E72 RID: 7794
		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _backTransform;

		// Token: 0x04001E73 RID: 7795
		[Token(Token = "0x4001E73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _animationTransform;

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4001E74")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform _finishTransform;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _myAnimationTarget;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4001E76")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _enemyAnimationTarget;

		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _myFinishTarget;

		// Token: 0x04001E78 RID: 7800
		[Token(Token = "0x4001E78")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _enemyFinishTarget;

		// Token: 0x04001E79 RID: 7801
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PetViewV2 _myPet;

		// Token: 0x04001E7A RID: 7802
		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private PetViewV2 _enemyPet;

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _myPetAnimationTarget;

		// Token: 0x04001E7C RID: 7804
		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _enemyPetAnimationTarget;

		// Token: 0x04001E7D RID: 7805
		[Token(Token = "0x4001E7D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _myPetFinishTarget;

		// Token: 0x04001E7E RID: 7806
		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Transform _enemyPetFinishTarget;

		// Token: 0x04001E7F RID: 7807
		[Token(Token = "0x4001E7F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _delay;

		// Token: 0x04001E80 RID: 7808
		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _flyDelay;

		// Token: 0x04001E81 RID: 7809
		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _flyDuration;

		// Token: 0x04001E82 RID: 7810
		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _animationHideDuration;

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _finishDuration;

		// Token: 0x04001E84 RID: 7812
		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Ease _scaleEasing;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Ease _xEasing;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Ease _yEasing;

		// Token: 0x04001E8B RID: 7819
		[Token(Token = "0x4001E8B")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine _playCor;

		// Token: 0x04001E8C RID: 7820
		[Token(Token = "0x4001E8C")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 _position;

		// Token: 0x04001E8D RID: 7821
		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0xA0")]
		private long _count;

		// Token: 0x04001E8E RID: 7822
		[Token(Token = "0x4001E8E")]
		[FieldOffset(Offset = "0xA8")]
		private ObjectPool<StoneDestroyElement> _pool;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnCompleteEvent ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__add_OnCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a566ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a566ac = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x80);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x80,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Duration ---
		float Gameplay_Combat_View_VFX_StoneDestroyElement__set_Duration(int param1,undefined4 param2)
		
		{
		  return *(float *)(param1 + 0x88);
		}
		*/


		/* --- GHIDRA: get_Delay ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__get_Delay
		               (int param1,float param2,undefined4 param3)
		
		{
		  *(float *)(param1 + 0x88) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_IsLeft ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__get_IsLeft
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x8c) = (undefined1)param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_Pool ---
		uint Gameplay_Combat_View_VFX_StoneDestroyElement__set_Pool(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 0x10) == 4);
		}
		*/


		/* --- GHIDRA: get_IsSkull ---
		void Gameplay_Combat_View_VFX_StoneDestroyElement__get_IsSkull(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_VFX_StoneDestroyElement__Play(param1,param1);
		  return;
		}
		*/

}
