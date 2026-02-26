using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Utils
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[DisallowMultipleComponent]
	public class LongTap : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDisposable
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002A00 File Offset: 0x00000C00
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public static float TimeOfStartDetect
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x5701", Offset = "0x5701", VA = "0x5701")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x5702", Offset = "0x5702", VA = "0x5702")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public static float TimeOfDetect
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x5703", Offset = "0x5703", VA = "0x5703")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x5704", Offset = "0x5704", VA = "0x5704")]
			set
			{
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x5705", Offset = "0x5705", VA = "0x5705")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Utils_LongTap__OnDestroy(int param1,undefined4 param2)
		
		{
		  Utils_LongTap__OnPointerUp(param1,param1);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x5706", Offset = "0x5706", VA = "0x5706", Slot = "7")]
		public virtual void Dispose()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x5707", Offset = "0x5707", VA = "0x5707")]
		public void RemoveAllEventHandlers()
		{
		/* --- GHIDRA: RemoveAllEventHandlers ---
		void Utils_LongTap__RemoveAllEventHandlers(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627ef = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event LongTap.LongTapHandler StartLongTapEvent
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x5708", Offset = "0x5708", VA = "0x5708")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x5709", Offset = "0x5709", VA = "0x5709")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event LongTap.LongTapHandler FinishLongTapEvent
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x570A", Offset = "0x570A", VA = "0x570A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x570B", Offset = "0x570B", VA = "0x570B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public event LongTap.LongTapHandler CancelLongTapEvent
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x570C", Offset = "0x570C", VA = "0x570C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x570D", Offset = "0x570D", VA = "0x570D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public event LongTap.LongTapHandler LongTapEvent
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x570E", Offset = "0x570E", VA = "0x570E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x570F", Offset = "0x570F", VA = "0x570F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002A30 File Offset: 0x00000C30
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public int CurrentLongTapDetectionCount
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x5710", Offset = "0x5710", VA = "0x5710")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x5711", Offset = "0x5711", VA = "0x5711")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public int CurrentStartLongTapDetectionCount
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x5712", Offset = "0x5712", VA = "0x5712")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x5713", Offset = "0x5713", VA = "0x5713")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public Vector2 StartTouchPosition
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x5714", Offset = "0x5714", VA = "0x5714")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x5715", Offset = "0x5715", VA = "0x5715")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x5716", Offset = "0x5716", VA = "0x5716", Slot = "8")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerDown ---
		void Utils_LongTap__OnPointerDown(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  bool bVar2;
		  
		  if (*(int *)(param1 + 0x20) == 0) {
		    bVar2 = *(int *)(param1 + 0x24) == 0;
		  }
		  else {
		    bVar2 = false;
		  }
		  *(bool *)(param2 + 0xbc) = bVar2;
		  Utils_LongTap__OnPointerUp(param1,param1);
		  if (((*(int *)(param1 + 0x20) != 0) ||
		      (((*(int *)(param1 + 0x24) != 0 && (iVar1 = *(int *)(param1 + 0x18), iVar1 != 0)) &&
		       ((**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14)),
		       *(int *)(param1 + 0x20) != 0)))) && (iVar1 = *(int *)(param1 + 0x14), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x5717", Offset = "0x5717", VA = "0x5717", Slot = "9")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerUp ---
		void Utils_LongTap__OnPointerUp(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int param3;
		  
		  if (DAT_ram_00a627f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Coroutine__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Coroutine__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Coroutine__get_Item__);
		    DAT_ram_00a627f8 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x30);
		  uVar2 = *(uint *)(iVar3 + 0xc);
		  if (0 < (int)*(uint *)(iVar3 + 0xc)) {
		    do {
		      param2_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x30),uVar2 - 1,
		                             Method_System_Collections_Generic_List_Coroutine__get_Item__);
		      func_ii_20511(param1,param2_00,0);
		      bVar1 = 1 < uVar2;
		      uVar2 = uVar2 - 1;
		    } while (bVar1);
		    iVar3 = *(int *)(param1 + 0x30);
		    param3 = *(int *)(iVar3 + 0xc);
		    *(undefined4 *)(iVar3 + 0xc) = 0;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    if (0 < param3) {
		      func_ii_2064(*(undefined4 *)(iVar3 + 8),0,param3,0);
		    }
		    return;
		  }
		  *(undefined4 *)(iVar3 + 0xc) = 0;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  return;
		}
		*/

		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x5718", Offset = "0x5718", VA = "0x5718")]
		private void StopDetectCoroutines()
		{
		/* --- GHIDRA: StopDetectCoroutines ---
		int Utils_LongTap__StopDetectCoroutines(undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a627f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap__DetectLongTapCoroutine_d__40_TypeInfo);
		    DAT_ram_00a627f9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Utils_LongTap__DetectLongTapCoroutine_d__40_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x5719", Offset = "0x5719", VA = "0x5719")]
		private IEnumerator DetectLongTapCoroutine(float time)
		{
		/* --- GHIDRA: DetectLongTapCoroutine ---
		int Utils_LongTap__DetectLongTapCoroutine(undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a627fa == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap__DetectStartLongTapCoroutine_d__41_TypeInfo);
		    DAT_ram_00a627fa = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Utils_LongTap__DetectStartLongTapCoroutine_d__41_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x571A", Offset = "0x571A", VA = "0x571A")]
		private IEnumerator DetectStartLongTapCoroutine(float delay)
		{
		/* --- GHIDRA: DetectStartLongTapCoroutine ---
		void Utils_LongTap__DetectStartLongTapCoroutine(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a627fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Coroutine___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Coroutine__TypeInfo);
		    DAT_ram_00a627fb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Coroutine__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Coroutine___ctor__);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x571B", Offset = "0x571B", VA = "0x571B")]
		public LongTap()
		{
		/* --- GHIDRA: .cctor ---
		void Utils_LongTap___cctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\0') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x15;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x14;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x13;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x12;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x11;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x01') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x10;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x16;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Utils_LongTap___ctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a627fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_TypeInfo);
		    DAT_ram_00a627fc = '\x01';
		  }
		  **(undefined8 **)(Utils_LongTap_TypeInfo + 0x5c) = 0x3e8000003f19999a;
		  return;
		}
		*/

		}

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x0")]
		private static float _timeOfDetect;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x4")]
		private static float _timeOfStartDetect;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x30")]
		private List<Coroutine> _detectCoroutines;

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000281 RID: 641
		[Token(Token = "0x2000044")]
		public delegate void LongTapHandler(LongTap sender);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TimeOfStartDetect ---
		void Utils_LongTap__get_TimeOfStartDetect(float param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a627ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_TypeInfo);
		    DAT_ram_00a627ec = '\x01';
		  }
		  if (*(int *)(Utils_LongTap_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_LongTap_TypeInfo);
		  }
		  *(float *)(*(int *)(Utils_LongTap_TypeInfo + 0x5c) + 4) = param1;
		  return;
		}
		*/


		/* --- GHIDRA: set_TimeOfStartDetect ---
		float Utils_LongTap__set_TimeOfStartDetect(undefined4 param1)
		
		{
		  if (DAT_ram_00a627ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_TypeInfo);
		    DAT_ram_00a627ed = '\x01';
		  }
		  if (*(int *)(Utils_LongTap_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_LongTap_TypeInfo);
		  }
		  return **(float **)(Utils_LongTap_TypeInfo + 0x5c);
		}
		*/


		/* --- GHIDRA: get_TimeOfDetect ---
		void Utils_LongTap__get_TimeOfDetect(float param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a627ee == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_TypeInfo);
		    DAT_ram_00a627ee = '\x01';
		  }
		  if (*(int *)(Utils_LongTap_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_LongTap_TypeInfo);
		  }
		  **(float **)(Utils_LongTap_TypeInfo + 0x5c) = param1;
		  return;
		}
		*/


		/* --- GHIDRA: add_StartLongTapEvent ---
		void Utils_LongTap__add_StartLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627f0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_StartLongTapEvent ---
		void Utils_LongTap__remove_StartLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627f1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_FinishLongTapEvent ---
		void Utils_LongTap__add_FinishLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_FinishLongTapEvent ---
		void Utils_LongTap__remove_FinishLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627f3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_CancelLongTapEvent ---
		void Utils_LongTap__add_CancelLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627f4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_CancelLongTapEvent ---
		void Utils_LongTap__remove_CancelLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627f5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_LongTapEvent ---
		void Utils_LongTap__add_LongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a627f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    DAT_ram_00a627f6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Utils_LongTap_LongTapHandler_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,Utils_LongTap_LongTapHandler_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_StartTouchPosition ---
		void Utils_LongTap__set_StartTouchPosition(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a627f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Coroutine__Add__);
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_TypeInfo);
		    DAT_ram_00a627f7 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x28) = *(undefined8 *)(param2 + 200);
		  param1_00 = *(int *)(param1 + 0x30);
		  if (*(int *)(Utils_LongTap_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_LongTap_TypeInfo);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(Utils_LongTap_TypeInfo + 0x5c) + 4);
		  if (DAT_ram_00a627fa == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_LongTap__DetectStartLongTapCoroutine_d__41_TypeInfo);
		    DAT_ram_00a627fa = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Utils_LongTap__DetectStartLongTapCoroutine_d__41_TypeInfo);
		  *(int *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  uVar2 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar1,0);
		  iVar1 = Method_System_Collections_Generic_List_Coroutine__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

}
