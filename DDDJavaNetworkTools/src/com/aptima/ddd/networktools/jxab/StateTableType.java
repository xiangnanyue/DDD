//
// This file was generated by the JavaTM Architecture for XML Binding(JAXB) Reference Implementation, v2.1-b02-fcs 
// See <a href="http://java.sun.com/xml/jaxb">http://java.sun.com/xml/jaxb</a> 
// Any modifications to this file will be lost upon recompilation of the source schema. 
// Generated on: 2009.05.25 at 05:05:58 PM EDT 
//

package com.aptima.ddd.networktools.jxab;

import java.io.Serializable;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;

/**
 * <p>
 * Java class for anonymous complex type.
 * 
 * <p>
 * The following schema fragment specifies the expected content contained within
 * this class.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base=&quot;{http://www.w3.org/2001/XMLSchema}anyType&quot;&gt;
 *       &lt;sequence&gt;
 *         &lt;element ref=&quot;{}StateName&quot;/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = { "stateName" })
@XmlRootElement(name = "StateTableType")
public class StateTableType  implements Serializable{

	@XmlElement(name = "StateName", required = true)
	protected StateName stateName;

	public StateTableType() {
		// TODO Auto-generated constructor stub
	}

	public StateTableType(StateName stateName) {
		super();
		this.stateName = stateName;
	}

	/**
	 * Gets the value of the stateName property.
	 * 
	 * @return possible object is {@link StateName }
	 * 
	 */
	public StateName getStateName() {
		return stateName;
	}

	/**
	 * Sets the value of the stateName property.
	 * 
	 * @param value
	 *            allowed object is {@link StateName }
	 * 
	 */
	public void setStateName(StateName value) {
		this.stateName = value;
	}

}