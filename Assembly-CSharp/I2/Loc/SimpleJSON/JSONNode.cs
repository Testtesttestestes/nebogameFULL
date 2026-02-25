using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013B9 RID: 5049
	[Token(Token = "0x20013B9")]
	public class JSONNode
	{
		// Token: 0x060077FC RID: 30716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077FC")]
		[Address(RVA = "0xC151", Offset = "0xC151", VA = "0xC151", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x170017B8 RID: 6072
		[Token(Token = "0x170017B8")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x60077FD")]
			[Address(RVA = "0xC152", Offset = "0xC152", VA = "0xC152", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60077FE")]
			[Address(RVA = "0xC153", Offset = "0xC153", VA = "0xC153", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170017B9 RID: 6073
		[Token(Token = "0x170017B9")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x60077FF")]
			[Address(RVA = "0xC154", Offset = "0xC154", VA = "0xC154", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007800")]
			[Address(RVA = "0xC155", Offset = "0xC155", VA = "0xC155", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06007801 RID: 30721 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007802 RID: 30722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017BA")]
		public virtual string Value
		{
			[Token(Token = "0x6007801")]
			[Address(RVA = "0xC156", Offset = "0xC156", VA = "0xC156", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007802")]
			[Address(RVA = "0xC157", Offset = "0xC157", VA = "0xC157", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06007803 RID: 30723 RVA: 0x00016098 File Offset: 0x00014298
		[Token(Token = "0x170017BB")]
		public virtual int Count
		{
			[Token(Token = "0x6007803")]
			[Address(RVA = "0xC158", Offset = "0xC158", VA = "0xC158", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007804")]
		[Address(RVA = "0xC159", Offset = "0xC159", VA = "0xC159", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007805")]
		[Address(RVA = "0xC15A", Offset = "0xC15A", VA = "0xC15A", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007806")]
		[Address(RVA = "0xC15B", Offset = "0xC15B", VA = "0xC15B", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007807")]
		[Address(RVA = "0xC15C", Offset = "0xC15C", VA = "0xC15C", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017BC")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007808")]
			[Address(RVA = "0xC15D", Offset = "0xC15D", VA = "0xC15D", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06007809 RID: 30729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017BD")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6007809")]
			[Address(RVA = "0xC15E", Offset = "0xC15E", VA = "0xC15E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600780A")]
		[Address(RVA = "0xC15F", Offset = "0xC15F", VA = "0xC15F", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600780B")]
		[Address(RVA = "0xC160", Offset = "0xC160", VA = "0xC160", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x000160B0 File Offset: 0x000142B0
		// (set) Token: 0x0600780D RID: 30733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017BE")]
		public virtual int AsInt
		{
			[Token(Token = "0x600780C")]
			[Address(RVA = "0xC161", Offset = "0xC161", VA = "0xC161", Slot = "18")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600780D")]
			[Address(RVA = "0xC162", Offset = "0xC162", VA = "0xC162", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x000160C8 File Offset: 0x000142C8
		// (set) Token: 0x0600780F RID: 30735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017BF")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600780E")]
			[Address(RVA = "0xC163", Offset = "0xC163", VA = "0xC163", Slot = "20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600780F")]
			[Address(RVA = "0xC164", Offset = "0xC164", VA = "0xC164", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06007810 RID: 30736 RVA: 0x000160E0 File Offset: 0x000142E0
		// (set) Token: 0x06007811 RID: 30737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017C0")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6007810")]
			[Address(RVA = "0xC165", Offset = "0xC165", VA = "0xC165", Slot = "22")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6007811")]
			[Address(RVA = "0xC166", Offset = "0xC166", VA = "0xC166", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x000160F8 File Offset: 0x000142F8
		// (set) Token: 0x06007813 RID: 30739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017C1")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6007812")]
			[Address(RVA = "0xC167", Offset = "0xC167", VA = "0xC167", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007813")]
			[Address(RVA = "0xC168", Offset = "0xC168", VA = "0xC168", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06007814 RID: 30740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017C2")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6007814")]
			[Address(RVA = "0xC169", Offset = "0xC169", VA = "0xC169", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06007815 RID: 30741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017C3")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6007815")]
			[Address(RVA = "0xC16A", Offset = "0xC16A", VA = "0xC16A", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007816")]
		[Address(RVA = "0xC16B", Offset = "0xC16B", VA = "0xC16B")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007817")]
		[Address(RVA = "0xC16C", Offset = "0xC16C", VA = "0xC16C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00016110 File Offset: 0x00014310
		[Token(Token = "0x6007818")]
		[Address(RVA = "0xC16D", Offset = "0xC16D", VA = "0xC16D")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00016128 File Offset: 0x00014328
		[Token(Token = "0x6007819")]
		[Address(RVA = "0xC16E", Offset = "0xC16E", VA = "0xC16E")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x600781A")]
		[Address(RVA = "0xC16F", Offset = "0xC16F", VA = "0xC16F", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x600781B")]
		[Address(RVA = "0xC170", Offset = "0xC170", VA = "0xC170", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600781C")]
		[Address(RVA = "0x1904", Offset = "0x1904", VA = "0x1904")]
		internal static string Escape(string aText)
		{
			return null;
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600781D")]
		[Address(RVA = "0xC171", Offset = "0xC171", VA = "0xC171")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600781E")]
		[Address(RVA = "0xC172", Offset = "0xC172", VA = "0xC172", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600781F")]
		[Address(RVA = "0xC173", Offset = "0xC173", VA = "0xC173")]
		public void SaveToStream(Stream aData)
		{
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007820")]
		[Address(RVA = "0xC174", Offset = "0xC174", VA = "0xC174")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007821")]
		[Address(RVA = "0xC175", Offset = "0xC175", VA = "0xC175")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007822")]
		[Address(RVA = "0xC176", Offset = "0xC176", VA = "0xC176")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007823")]
		[Address(RVA = "0xC177", Offset = "0xC177", VA = "0xC177")]
		public void SaveToFile(string aFileName)
		{
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007824")]
		[Address(RVA = "0xC178", Offset = "0xC178", VA = "0xC178")]
		public string SaveToBase64()
		{
			return null;
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007825")]
		[Address(RVA = "0x18F5", Offset = "0x18F5", VA = "0x18F5")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007826")]
		[Address(RVA = "0xC179", Offset = "0xC179", VA = "0xC179")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007827")]
		[Address(RVA = "0xC17A", Offset = "0xC17A", VA = "0xC17A")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007828")]
		[Address(RVA = "0xC17B", Offset = "0xC17B", VA = "0xC17B")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007829")]
		[Address(RVA = "0x18F7", Offset = "0x18F7", VA = "0x18F7")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600782A")]
		[Address(RVA = "0xC17C", Offset = "0xC17C", VA = "0xC17C")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600782B")]
		[Address(RVA = "0xC17D", Offset = "0xC17D", VA = "0xC17D")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600782C")]
		[Address(RVA = "0xC17E", Offset = "0xC17E", VA = "0xC17E")]
		public JSONNode()
		{
		}
	}
}
